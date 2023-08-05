﻿using BankingEx.EFModels;
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
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(int id)
        {
            Customer customer = EFCustomerContext.GetCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Customer customer)
        {
            try
            {
                bool success = EFCustomerContext.UpdateCustomer(customer);
                if (success)
                {
                    return RedirectToAction("List");
                }
                ViewBag.ErrorMessage = "Record not updated. Pls try again.";
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Record not updated. Exception : " + ex.Message;
            }
            return View(customer);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Customer customer = EFCustomerContext.GetCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            bool isDeleted = EFCustomerContext.Delete(customer.Id);
            if (isDeleted)
            {
                ViewBag.ErrorMessage = "Record not deleted! Please try again.";
            }
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Customer customer = EFCustomerContext.GetCustomerById(id);
            return View(customer);
        }
    }
}