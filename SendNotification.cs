using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace ONELLOTARJANNEST10178800CLDV6211POEFINAL
{
    public static class SendNotification
    {
        [FunctionName("SendNotification")]
        public static async Task Run([ActivityTrigger] Notification notification, ILogger log)
        {
            log.LogInformation($"Sending notification: {notification.Message}");
            // Add logic to send notification
            await Task.CompletedTask;
        }
    }
}
