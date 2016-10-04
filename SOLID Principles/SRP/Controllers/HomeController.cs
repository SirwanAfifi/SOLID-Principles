using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SRP.Core;

namespace SRP.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerSearch _customerSearch;

        public HomeController(CustomerSearch customerSearch)
        {
            _customerSearch = customerSearch;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<Customer> GetData(string criteria, string searchby)
        {
            List<Customer> data = null;
            switch (searchby)
            {
                case "companyname":
                    data = _customerSearch.SearchByCompanyName(criteria);
                    break;
                case "contactname":
                    data = _customerSearch.SearchByContactName(criteria);
                    break;
                case "contry":
                    data = _customerSearch.SearchByCountry(criteria);
                    break;
            }
            return data;
        }

        [HttpPost]
        public IActionResult Search(string criteria, string searchby)
        {
            List<Customer> model = GetData(criteria, searchby);
            ViewBag.Criteria = criteria;
            ViewBag.SearchBy = searchby;
            return View(model);
        }

        [HttpPost]
        public FileResult Export(string criteria, string searchby)
        {
            List<Customer> data = GetData(criteria, searchby);
            string exportData = CustomerDataExporter.ExportToCsv(data);
            return File(System.Text.Encoding.ASCII.GetBytes(exportData), "application/Excel");
        }
    }
}
