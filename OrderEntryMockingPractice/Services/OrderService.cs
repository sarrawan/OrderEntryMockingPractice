using OrderEntryMockingPractice.Models;

namespace OrderEntryMockingPractice.Services
{
    public class OrderService
    {
        private IOrderFulfillmentService _orderFulfillmentService;

        public OrderService(IOrderFulfillmentService orderFulfillment)
        {
            _orderFulfillmentService = orderFulfillment;
        }

        public OrderSummary PlaceOrder(Order order)
        {
            return null;
        }
    }
}
