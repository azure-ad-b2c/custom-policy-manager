using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

namespace B2CPolicyManagerUI
{
	public class ActionLogger
		:ILogger
	{
		private Action<String> _writer { get; }

		public LogLevel MinimumLevel { get; set; } = LogLevel.Information;

		public ActionLogger( Action<String> writer )
		{
			_writer = writer;
		}
		public IDisposable BeginScope<TState>( TState state ) where TState : notnull
			=> default;

		public bool IsEnabled( LogLevel logLevel )
			=> logLevel >= MinimumLevel;

		public void Log<TState>( LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter )
		{
			if( IsEnabled( logLevel ) && _writer != null ) {
				_writer( $"[{DateTime.Now}] - {logLevel}: {formatter( state, exception )}" );
			}
		}

		
	}
}
