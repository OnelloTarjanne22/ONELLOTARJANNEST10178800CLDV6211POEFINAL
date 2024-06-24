using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
namespace ONELLOTARJANNEST10178800CLDV6211POEFINAL
{
    public static class SaveOrderInfo
    {
        [FunctionName("SaveOrderInfo")]
        public static async Task Run([ActivityTrigger] Order order, ILogger log)
        {
            log.LogInformation($"Saving order info for Order ID: {order.OrderId}");
            // Add logic to save order info
            await Task.CompletedTask;
        }
    }
}
