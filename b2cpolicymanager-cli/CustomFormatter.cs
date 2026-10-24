using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace b2cpolicymanager_cli;
sealed class CustomFormatter
	:ConsoleFormatter, IDisposable
{
	private readonly IDisposable? _optionsReloadToken;
	private CustomFormatterOptions _formatterOptions;

	// See https://stackoverflow.com/questions/2743260/is-it-possible-to-write-to-the-console-in-colour-in-net
	static readonly string NL          = Environment.NewLine; // shortcut
	static readonly string ESC         = "\x1b";              // shortcut
	static readonly string NORMAL      = Console.IsOutputRedirected ? "" : $"{ESC}[39m";
	static readonly string RED         = Console.IsOutputRedirected ? "" : $"{ESC}[91m";
	static readonly string GREEN       = Console.IsOutputRedirected ? "" : $"{ESC}[92m";
	static readonly string YELLOW      = Console.IsOutputRedirected ? "" : $"{ESC}[93m";
	static readonly string BLUE        = Console.IsOutputRedirected ? "" : $"{ESC}[94m";
	static readonly string MAGENTA     = Console.IsOutputRedirected ? "" : $"{ESC}[95m";
	static readonly string CYAN        = Console.IsOutputRedirected ? "" : $"{ESC}[96m";
	static readonly string GREY        = Console.IsOutputRedirected ? "" : $"{ESC}[97m";
	static readonly string BOLD        = Console.IsOutputRedirected ? "" : $"{ESC}[1m";
	static readonly string NOBOLD      = Console.IsOutputRedirected ? "" : $"{ESC}[22m";
	static readonly string UNDERLINE   = Console.IsOutputRedirected ? "" : $"{ESC}[4m";
	static readonly string NOUNDERLINE = Console.IsOutputRedirected ? "" : $"{ESC}[24m";
	static readonly string REVERSE     = Console.IsOutputRedirected ? "" : $"{ESC}[7m";
	static readonly string NOREVERSE   = Console.IsOutputRedirected ? "" : $"{ESC}[27m";
	static readonly string RESET       = Console.IsOutputRedirected ? "" : $"{ESC}[0m";

	private readonly static Dictionary<LogLevel, String> logLevelMap
		= new()
		{
			[LogLevel.Trace] = $"{GREY}TRC",
			[LogLevel.Debug] = $"{CYAN}DBG",
			[LogLevel.Information] = $"INF",
			[LogLevel.Warning] = $"{YELLOW}WRN",
			[LogLevel.Error] = $"{RED}ERR",
			[LogLevel.Critical] = $"{RED}{REVERSE}BUG"
		};

	public CustomFormatter( IOptionsMonitor<CustomFormatterOptions> options )
		// Case insensitive
		: base( nameof( CustomFormatter ) )
	{
		_optionsReloadToken = options.OnChange( ReloadLoggerOptions );
		_formatterOptions = options.CurrentValue;
	}

	private void ReloadLoggerOptions( CustomFormatterOptions options ) =>
		_formatterOptions = options;

	public override void Write<TState>(
		in LogEntry<TState> logEntry,
		IExternalScopeProvider? scopeProvider,
		TextWriter textWriter )
	{
		String? message =
			logEntry.Formatter?.Invoke(
				logEntry.State, 
				logEntry.Exception
			);

		if( message is null )
		{
			return;
		}

		textWriter.WriteLine( $"{DateTime.Now.ToString( _formatterOptions.TimestampFormat ) } {logLevelMap[logEntry.LogLevel]} {message}{RESET}" );
	}

	// IDisposable implementation
	public void Dispose()
	{
		_optionsReloadToken?.Dispose();
	}
}
