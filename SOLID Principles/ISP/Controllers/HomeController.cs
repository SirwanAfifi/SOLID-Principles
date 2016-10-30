using System;
using ISP.Core;
using Microsoft.AspNetCore.Mvc;

namespace ISP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(string paymentmode)
        {
            Customer customer = new Customer();
            Address address = new Address();
            CardInfo cardInfo = null;

            Order order = new Order();
            order.OrderId = new Random().Next(1000, 9000);
            order.Customer = customer;
            order.ShippingAddress = address;
            order.CardInfo = cardInfo;

            if (paymentmode == "card")
            {
                OnlineOrderProcessor oop = new OnlineOrderProcessor();
                cardInfo = new CardInfo();
                cardInfo.CardNo = "555555555555555444444";
                cardInfo.ExpiryMonth = 12;
                cardInfo.ExpiryYear = 2015;
                order.CardInfo = cardInfo;
                oop.ValidateCardInfo(cardInfo);
                oop.ValidateShippingAddress(address);
                oop.ProcessOrder(order);
            }
            else
            {
                CashOnDeliveryOrderProcessor codop = new CashOnDeliveryOrderProcessor();
                codop.ValidateShippingAddress(address);
                codop.ProcessOrder(order);
            }

            return View("Success", order);
        }
    }
}
