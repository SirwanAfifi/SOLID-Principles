using System.Collections.Generic;
using System.Linq;

namespace SRP.Core
{
    public class CustomerSearch
    {
        private readonly AppDbContext _ctx;

        public CustomerSearch(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Customer> SearchByCountry(string country)
        {
            var query = from c in _ctx.Customers
                        where c.Country.Contains(country)
                        orderby c.CustomerId ascending
                        select c;
            return query.ToList();
        }

        public List<Customer> SearchByCompanyName(string company)
        {
            var query = from c in _ctx.Customers
                        where c.CompanyName.Contains(company)
                        orderby c.CustomerId ascending
                        select c;
            return query.ToList();
        }

        public List<Customer> SearchByContactName(string contact)
        {
            var query = from c in _ctx.Customers
                        where c.ContactName.Contains(contact)
                        orderby c.CustomerId ascending
                        select c;
            return query.ToList();
        }
    }
}