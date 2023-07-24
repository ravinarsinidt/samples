using BankingEx.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BankingEx.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContentData()
        {
            return Content("Hi Ravi Kumar");
        }

        public IActionResult JsonData()
        {
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Test",
            };

            //Tranform it to Json object
            string customerData = JsonConvert.SerializeObject(customer);
            return Json(customerData);
        }

        public IActionResult FileData()
        {
            return File("/SampleFile.json", "application/json", "myfile.json");
        }

        public IActionResult GoToHome()
        {
            return Redirect("/home/index");
        }

        public IActionResult GoToAction()
        {
            return RedirectToAction("JsonData");
        }

        public IActionResult PartialViewData()
        {
            return PartialView();
        }
    }
}
