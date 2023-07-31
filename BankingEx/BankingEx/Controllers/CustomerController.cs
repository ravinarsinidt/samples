using BankingEx.EFModels;
using BankingEx.EFPersistanceLayer;
using Microsoft.AspNetCore.Mvc;
using System;
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
            bool isSuccess = EFCustomerContext.Create(customer);
            if (isSuccess)
            {
                return RedirectToAction("List");
            }

            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            List<Customer> customers = EFCustomerContext.GetCustomers();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Test()
        {
            return View();
        }
    }
}