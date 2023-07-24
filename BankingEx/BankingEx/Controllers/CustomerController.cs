using BankingEx.Models;
using BankingEx.PersistanceLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BankingEx.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            bool isSuccess = CustomerContext.Create(customer);
            if (isSuccess)
            {
                return RedirectToAction("List");
            }

            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            List<Customer> customers = CustomerContext.GetCustomers();
            return View(customers);
        }
    }
}
