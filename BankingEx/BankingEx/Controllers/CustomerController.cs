﻿using BankingEx.EFModels;
using BankingEx.EFPersistanceLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;

namespace BankingEx.Controllers
{
    [Authorize]
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
            if (ModelState.IsValid)
            {
                bool isSuccess = EFCustomerContext.Create(customer);
                if (isSuccess)
                {
                    return RedirectToAction("List");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Model is not valid.";
            }

            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            try
            {
                List<Customer> customers = EFCustomerContext.GetCustomers();
                return View(customers);
            }
            catch (Exception)
            {
                throw;
            }
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