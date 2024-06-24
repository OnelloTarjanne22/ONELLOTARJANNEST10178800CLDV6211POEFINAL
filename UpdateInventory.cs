using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace ONELLOTARJANNEST10178800CLDV6211POEFINAL
{


    public static class UpdateInventory
    {
        [FunctionName("UpdateInventory")]
        public static async Task Run([ActivityTrigger] Order order, ILogger log)
        {
            log.LogInformation($"Updating inventory for Order ID: {order.OrderId}");
            // Add logic to update inventory
            await Task.CompletedTask;
        }
    }

}
