using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ONELLOTARJANNEST10178800CLDV6211POEFINAL
{
    public static class OrderProcessingOrchestrator
    {
        [FunctionName("OrderProcessingOrchestrator")]
        public static async Task RunOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            var order = context.GetInput<Order>();

            await context.CallActivityAsync("UpdateInventory", order);
            await context.CallActivityAsync("ProcessPayment", order);
            await context.CallActivityAsync("SaveOrderInfo", order);

            var notification = new Notification { Message = "Order processed successfully." };
            await context.CallActivityAsync("SendNotification", notification);
        }
    }

}