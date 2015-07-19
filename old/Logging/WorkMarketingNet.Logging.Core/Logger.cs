using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.Logging;

namespace WorkMarketingNet.Logging.Core
{
	public class Logger : ILogger
	{
		private readonly Microsoft.Framework.Logging.ILogger _logger;

		public Logger(ILoggerFactory loggerfactory)
		{
			// Add the console logger.
			loggerfactory.AddConsole(minLevel: LogLevel.Debug);
			_logger = loggerfactory.CreateLogger(typeof(Logger).FullName);
		}

		/// <summary>
		/// Log a message object with the Debug level.
		/// </summary>
		/// <param name="message">The message object to log.</param>
		public virtual void Debug(object message)
		{
			_logger.LogDebug(message.ToString());
			//_log.Debug(message);
		}

		/// <summary>
		/// Log a message object with the Debug level including the stack trace of the System.Exception passed as a parameter.
		/// </summary>
		/// <param name="message">The message object to log</param>
		/// <param name="exception">The exception to log, including its stack trace</param>
		public virtual void Debug(object message, Exception exception)
		{
			//_log.Debug(message, exception);
		}

		/// <summary>
		/// Logs a formatted message string with the Debug level.
		/// </summary>
		/// <param name="format">A String containing zero or more format items</param>
		/// <param name="args">An Object array containing zero or more objects to format</param>
		public virtual void DebugFormat(string format, params object[] args)
		{
			//_log.DebugFormat(format, args);
		}

		public virtual void Info(object message)
		{
			//_log.Info(message);
		}

		public virtual void Info(object message, Exception exception)
		{
			//_log.Info(message, exception);
		}

		public virtual void InfoFormat(string format, params object[] args)
		{
			//_log.InfoFormat(format, args);
		}

		public virtual void Warn(object message)
		{
			//_log.Warn(message);
		}

		public virtual void Warn(object message, Exception exception)
		{
			//_log.Warn(message, exception);
		}

		public virtual void WarnFormat(string format, params object[] args)
		{
			//_log.WarnFormat(format, args);
		}

		public virtual void Error(object message)
		{
			//_log.Error(message);
		}

		public virtual void Error(object message, Exception exception)
		{
			//_log.Error(message, exception);
		}

		public virtual void ErrorFormat(string format, params object[] args)
		{
			//_log.ErrorFormat(format, args);
		}

		public virtual void Fatal(object message)
		{
			//_log.Fatal(message);
		}

		public virtual void Fatal(object message, Exception exception)
		{
			//_log.Fatal(message, exception);
		}

		public virtual void FatalFormat(string format, params object[] args)
		{
			//_log.FatalFormat(format, args);
		}
	}
}
