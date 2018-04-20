using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoLibrary.Models;
using VideoLibrary.ViewModels;

namespace VideoLibrary.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
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

            return View (_customers);
        }
    }
}