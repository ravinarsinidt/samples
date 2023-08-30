using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System;
using BankingEx.PersistanceLayer;
using BankingEx.Models;
using Microsoft.AspNetCore.Http;
using BankingEx.EFModels;

namespace BankingEx.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.ShowError = false;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            Employee loggedInUser = EmployeeContext.Login(userName, password);
            if (loggedInUser != null)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, loggedInUser.Name));

                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                AuthenticationProperties authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);
                return RedirectToAction("List", "Customer");
            }
            else
            {
                ViewBag.ShowError = true;
                ViewBag.UserName = userName;
                return View();
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("login");
        }
    }
}
