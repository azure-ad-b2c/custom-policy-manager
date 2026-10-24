using System.IO.Enumeration;
using System.Text.Json;

using B2CPolicyManager;

using b2cpolicymanager_cli;

using CommandLine;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

using static b2cpolicymanager_cli.Options;

Options? options = null;

// Resolve command line options that are environment references (starting with "env:")
var expandedArgs
	= args.Select(
		arg =>
			arg.StartsWith( "env:", StringComparison.CurrentCultureIgnoreCase )
				? Environment.GetEnvironmentVariable( arg[  4 ..] ) ?? ""
				: arg
	);

var parserResult = Parser.Default.ParseArguments<ListOptions, GetOptions, DeployOptions>( expandedArgs )
	.WithParsed<Options>(
		opts => options = opts
	);

using ILoggerFactory loggerFactory
	= LoggerFactory.Create(
		builder => builder
			.AddConsole(
				opts =>
				{
					opts.FormatterName = "CustomFormatter";
				}
			)
			.AddConsoleFormatter<CustomFormatter, CustomFormatterOptions>(
				opts =>
				{
					opts.TimestampFormat = "HH:mm:ss.fff";
				}
			)
			.SetMinimumLevel(
				options?.Verbose ?? true
					? LogLevel.Trace
					: LogLevel.Information
			)
	);

ILogger logger = loggerFactory.CreateLogger<Program>();

if( options == null )
{
	logger.LogCritical( "Invalid command line options" );

	// Environment.Exit bypasses the using disposal, losing queued console log messages
	loggerFactory.Dispose();
	Environment.Exit( 1 );
}

logger.LogDebug(
	"Options: {options}",
	JsonSerializer.Serialize( 
		options, 
		new JsonSerializerOptions
		{
			WriteIndented = true 
		} 
	) 
);

AuthenticationHelperBase authHelper;

if( options.Interactive )
{
	authHelper = new PublicAuthenticationHelper(
		options.TenantId,
		options.AppId
	);
}
else
{
	if( String.IsNullOrEmpty( options.AppSecret ) )
	{
		logger.LogCritical( "Either --appsecret or --interactive must be supplied" );
		loggerFactory.Dispose();
		Environment.Exit( 1 );
	}

	authHelper = new ConfidentialAuthenticationHelper(
		options.TenantId,
		options.AppId,
		options.AppSecret
	);
}

 var policyManager = new PolicyManager( authHelper );

await parserResult
	.MapResult(
		async ( ListOptions opts ) =>
		{
			foreach( var policy in await policyManager.GetPoliciesAsync( logger ) )
			{
				logger.LogInformation( "Policy: {policy}", policy );
			}
		},
		async ( GetOptions opts ) =>
		{
			var policies = opts.PolicyNames.Any()
				? opts.PolicyNames
				: await policyManager.GetPoliciesAsync( logger );

			// Names containing wildcards are matched against the tenant's policy list
			if( policies.Any( name => name.Contains( '*' ) || name.Contains( '?' ) ) )
			{
				var allPolicies = await policyManager.GetPoliciesAsync( logger );

				policies = policies
					.SelectMany(
						pattern => allPolicies.Where( policy => FileSystemName.MatchesSimpleExpression( pattern, policy ) )
					)
					.Distinct( StringComparer.OrdinalIgnoreCase )
					.ToList();

				if( !policies.Any() )
				{
					logger.LogWarning( "No policies matched the requested pattern(s)" );
				}
			}

			var fetched = 0;

			await foreach( var policy in policyManager.GetPolicyDefinitionsAsync( logger, policies ) )
			{
				var path = Path.Join( opts.Folder, Path.ChangeExtension( policy.Id, ".xml" ) );

				await File.WriteAllTextAsync( path, policy.Text );
				logger.LogDebug( "Saved policy {Policy} to {Path}", policy.Id, path );
				fetched++;
			}

			logger.LogInformation( "Fetched {Count} of {Total} policies", fetched, policies.Count() );
		},
		async ( DeployOptions opts ) =>
		{
			var fileNames = opts.PolicyNames
				.SelectMany(
					policyName => Directory.EnumerateFiles(
						opts.Folder,
						Path.ChangeExtension( policyName, ".xml" ),
						// File names should match policy names case-insensitively even on Linux
						new EnumerationOptions { MatchCasing = MatchCasing.CaseInsensitive }
					)
				);

			await policyManager.DeployPoliciesAsync( logger, fileNames );
		},
		errs =>
		{
			logger.LogError( "Invalid command line options" );
			loggerFactory.Dispose();
			Environment.Exit( 1 );

			// never gets here, but the compiler doesn't know that
			return Task.CompletedTask;
		}
	)
;

