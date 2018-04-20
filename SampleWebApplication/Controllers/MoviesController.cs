using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoLibrary.Models;
using VideoLibrary.ViewModels;

namespace VideoLibrary.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Super Man" };
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

            RandomMovieViewModel viewModel = new RandomMovieViewModel();
            viewModel.Movie = movie;
            viewModel.Customers = customers;

            return View (viewModel);
            //return Content ("Hello");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {Page=1, Sort ="name"});


        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year, int month) {

            return Content(year+"/"+month);
        }
    }
}
