using BankingEx.EFModels;
using BankingEx.EFPersistanceLayer;
using Microsoft.AspNetCore.Mvc;

namespace BankingEx.Controllers
{
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
            return View();
        }
    }
}
