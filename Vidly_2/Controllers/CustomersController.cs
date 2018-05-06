using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2.Models;

namespace Vidly_2.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> _customers = new List<Customer>()
        {
            new Customer
            {
                Id = 0,
                Name = "Buzz Lightyear"
            },
            new Customer
            {
                Id = 1,
                Name = "Chuck Armstrong"
            }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers);
        }

        public ActionResult CustomerDetails(int? id)
        {
            if (id == null || id >= _customers.Count)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                return View(_customers[id.Value]);
            }
        }
    }
}