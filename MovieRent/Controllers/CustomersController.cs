using MovieRent.Models;
using MovieRent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRent.Controllers
{
    public class CustomersController : Controller
    {
        //HARDCODED FOR NOW, TODO: DATABASE
        List<Customer> customers = new List<Customer>
            {
                new Customer { name="John Smith", id=0 },
                new Customer { name="Donald Duck", id=1 },
                new Customer { name="Jeremy McOwell", id=2 },
                new Customer { name="Samantha Jones", id=3 },
                new Customer { name="Adam Tuck", id=4 },
                new Customer { name="Garry Smod", id=5 },
            };


        // GET: Customers
        public ActionResult Index()
        {
            
            var viewModel = new CustomerViewModel
            {
                customerList = customers
        };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {

            foreach (var customer in customers)
            {
                if (customer.id == id)
                    return View(customer);
            }
            return HttpNotFound();
        }
    }
}