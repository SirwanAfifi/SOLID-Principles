using Microsoft.AspNetCore.Mvc;
using OCP.Core;
using OCP.Models;

namespace OCP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IncomeDetails obj)
        {
            ICountryTaxCalculator t = null;
            switch (obj.Country)
            {
                case "USA":
                    t = new TaxCalculatorForUs();
                    break;
                case "UK":
                    t = new TaxCalculatorForUk();
                    break;
                case "IN":
                    t = new TaxCalculatorForIn();
                    break;
            }

            t.TotalIncome = obj.TotalIncome;
            t.TotalDeduction = obj.TotalDeduction;
            TaxCalculator cal = new TaxCalculator();
            ViewBag.TotalTax = cal.Calculate(t);
            return View("Index", obj);
        }
    }
}
