namespace ISP.Core
{
    public interface IOrderProcessor
    {
        bool ValidateShippingAddress(Address obj);
        void ProcessOrder(Order obj);
    }
}