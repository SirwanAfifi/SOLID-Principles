namespace ISP.Core
{
    public class CashOnDeliveryOrderProcessor : IOrderProcessor
    {
        public bool ValidateShippingAddress(Address obj)
        {
            // validate shipping destination
            return true;
        }

        public void ProcessOrder(Order obj)
        {
            // do something with obj
        }
    }
}