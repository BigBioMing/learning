using DotNetCore.CAP;

namespace CapDemo.Services
{
    public class SubscriberService : ISubscriberService, ICapSubscribe
    {
        [CapSubscribe("capdemo.services.order.orderCreated")]
        public void CheckReceivedMessage(object order)
        {
        }
    }
}
