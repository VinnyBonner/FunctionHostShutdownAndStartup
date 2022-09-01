using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace HostShutdownStartupExample
{
    public class TimerTrigger
    {
        [FunctionName("TimerTrigger")]
        public void Run([TimerTrigger("0 0 0 0 1 *", RunOnStartup = true)]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.UtcNow}");

            // Check table for unprocessed shutdowns.
            // If unprocessed shutdowns 
                // Send http request
                // mark unprocessed shutdown as processed
            // else
                // do nothing
        }
    }
}
