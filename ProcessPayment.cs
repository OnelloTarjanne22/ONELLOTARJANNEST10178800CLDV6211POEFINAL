using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;


namespace ONELLOTARJANNEST10178800CLDV6211POEFINAL
{
   public static class ProcessPayment
{
    [FunctionName("ProcessPayment")]
    public static async Task Run([ActivityTrigger] Order order, ILogger log)
    {
        log.LogInformation($"Processing payment for Order ID: {order.OrderId}");
        // Add logic to process payment
        await Task.CompletedTask;
    }
}
}
