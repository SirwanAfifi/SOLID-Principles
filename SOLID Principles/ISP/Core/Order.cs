namespace ISP.Core
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public Address ShippingAddress { get; set; }
        public CardInfo CardInfo { get; set; }
    }
}