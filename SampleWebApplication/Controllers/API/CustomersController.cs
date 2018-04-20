using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Http;
using VideoLibrary.Models;
using VideoLibrary.ViewModels;


namespace VideoLibrary.Controllers
{
    public class CustomerController : ApiController
    {   
        [HttpGet]
        public IEnumerable<Customer> GetCustomers() {
            return test.getCust();
        }


    }

    public static class test {

        public static List<Customer>  getCust() {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Cust1"
                },

                new Customer
                {
                    Id = 2,
                    Name = "Cust2"

                },
                new Customer
                {
                    Id = 3,
                    Name = "Cust3"

                },
                new Customer
                {
                    Id = 4,
                    Name = "Cust4"

                },
            };

            CustomersViewModel _customers = new CustomersViewModel();
            _customers.Customers = customers;
            return _customers.Customers;
        }
    }
}
