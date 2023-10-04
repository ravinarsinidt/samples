using Microsoft.AspNetCore.Mvc;

namespace BankingEx.Controllers
{
    public class HttpStatusController : Controller
    {
        public IActionResult FileNotFound()
        {
            return View();
        }
    }
}
