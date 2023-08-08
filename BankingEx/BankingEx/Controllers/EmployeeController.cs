using BankingEx.Models;
using BankingEx.PersistanceLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BankingEx.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult List()
        {
            List<Employee> employees = EmployeeContext.GetEmployees();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Employee employee = EmployeeContext.GetEmployeeById(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            bool isSuccess = EmployeeContext.Create(employee);
            if (isSuccess)
            {
                return RedirectToAction("List");
            }

            return View(employee);
        }
    }
}
