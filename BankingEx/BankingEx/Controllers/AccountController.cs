using BankingEx.EFModels;
using BankingEx.EFPersistanceLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace BankingEx.Controllers
{
    [Authorize(Roles = "admin, CAU, SAU")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Customers = EFCustomerContext.GetCustomers();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Account account)
        {
            bool success = EFAccountContext.Create(account);
            if (success)
            {
                return RedirectToAction("list");
            }
            ViewBag.Customers = EFCustomerContext.GetCustomers();
            ViewBag.ErrorMessage = "Account not created. Please contact admin for details!";
            return View(account);
        }

        [HttpGet]
        public IActionResult List()
        {
            try
            {
                List<Account> accounts = EFAccountContext.GetAccounts();
                string data = JsonConvert.SerializeObject(accounts);
                TempData["AccountsList"] = data;
                return View(accounts);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult Download1()
        {
            string accountsJson = (string)TempData["AccountsList"];
            TempData.Keep();
            return Content(accountsJson);
        }

        [HttpGet]
        public IActionResult Download2()
        {
            string accountsJson = (string)TempData["AccountsList"];
            TempData.Keep();
            return Content(accountsJson);
        }

        [HttpGet]
        public IActionResult Download3()
        {
            return RedirectToActionPermanent("download1");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Account account = EFAccountContext.GetAccountById(id);
            return View(account);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Account account = EFAccountContext.GetAccountById(id);
            return View(account);
        }

        [HttpPost]
        public IActionResult Delete(Account account)
        {
            bool success = EFAccountContext.Delete(account.Id);
            if (success)
            {
                return RedirectToAction("List");
            }

            return View(account);
        }
    }
}
