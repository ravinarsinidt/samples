using BankingEx.ViewModels;
using BankingEx.EFPersistanceLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using BankingEx.Utilities;
using DataModels = BankingEx.EFModels;

namespace BankingEx.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            List<string> states = new List<string>
            {
                "TS",
                "AP",
                "TN",
                "MH",
                "KT",
                "MP"
            };

            ViewBag.States = states;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                //Convert View Model to EF Model
                DataModels.Customer c = DataMapper.CovertCustomerViewModelToEFModel(customer);
                bool isSuccess = EFCustomerContext.Create(c);
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
                List<DataModels.Customer> customers = EFCustomerContext.GetCustomers();
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
            DataModels.Customer customer = EFCustomerContext.GetCustomerById(id);
            return View(customer);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            DataModels.Customer customer = EFCustomerContext.GetCustomerById(id);
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
            DataModels.Customer customer = EFCustomerContext.GetCustomerById(id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult GetCities(string cityId)
        {
            List<string> cities = new List<string>();
            if(cityId == "TS")
            {
                cities.Add("HYD");
                cities.Add("KMM");
            }
            else if(cityId == "AP")
            {
                cities.Add("VIZ");
                cities.Add("VIJA");
            }
            else
            {
                cities.Add("City1");
                cities.Add("City2");
            }

            return Json(cities);
        }
    }
}