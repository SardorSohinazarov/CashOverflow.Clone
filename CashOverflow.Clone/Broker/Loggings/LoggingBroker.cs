using System;
using Microsoft.Extensions.Logging;

namespace CashOverflow.Clone.Broker.Loggings
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger<LoggingBroker> logger;

        public LoggingBroker(ILogger<LoggingBroker> logger)=>
            this.logger = logger;

        public void LogCritical(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
