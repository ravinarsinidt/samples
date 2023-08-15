using AudreeBankApi.EFDataContext;
using AudreeBankApi.Persistance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AudreeBankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(Customer customer, int x)
        {
            bool result = CustomerPersistance.Create(customer);
            return Created("", result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Customer> result = CustomerPersistance.Get();
            return Ok(result);
        }
    }
}
