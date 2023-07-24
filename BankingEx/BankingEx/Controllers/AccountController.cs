using BankingEx.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BankingEx.Models;

namespace BankingEx.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContentData(int id)
        {
            if(GenderEnum.Male == (GenderEnum)id)
            {
                return Content("He is Male");
            }
            else if((int)GenderEnum.Female == id)
            {
                return Content("He is Female");
            }
            else
            {
                return Content("He is 3rd Gender");
            }
            
        }
    }
}
