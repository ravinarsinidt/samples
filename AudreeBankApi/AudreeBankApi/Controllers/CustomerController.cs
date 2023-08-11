using AudreeBankApi.EFDataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AudreeBankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            string connectionString = "Server=RAVINARSINI;Database=NewBank;User Id=sa;Password=adminadmin;encrypt=false";
            DbContextOptionsBuilder<AudreeBankData> optionsBuilder = new DbContextOptionsBuilder<AudreeBankData>();
            optionsBuilder.UseSqlServer(connectionString);
            AudreeBankData ctx = new AudreeBankData(optionsBuilder.Options);

            ctx.Customers.Add(customer);
            ctx.SaveChanges();
            return Ok();
        }
    }
}
