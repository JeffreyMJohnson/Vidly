using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2.Models;

namespace Vidly_2.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers
                .Include(c => c.MembershipType)
                .ToList();

            return View(customers);
        }

        public ActionResult CustomerDetails(int? id)
        {
            var customers = _context.Customers.ToList();
            if (id == null || customers.All(c => c.Id != id))
            {
                return new HttpNotFoundResult();
            }
            else
            {
                var customer = customers.FirstOrDefault(c => c.Id == id);
                return View(customer);
            }
        }
    }
}