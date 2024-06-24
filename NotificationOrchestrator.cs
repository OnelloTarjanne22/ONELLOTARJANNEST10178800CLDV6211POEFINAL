using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ONELLOTARJANNEST10178800CLDV6211POEFINAL
{
    public static class NotificationOrchestrator
    {
        [FunctionName("NotificationOrchestrator")]
        public static async Task RunOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            var notification = context.GetInput<Notification>();

            await context.CallActivityAsync("SendNotification", notification);
        }
    }

}
