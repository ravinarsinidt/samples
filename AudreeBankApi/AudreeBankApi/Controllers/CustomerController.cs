using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AudreeBankApi.PersistanceLayer.EFDataContext;
using AudreeBankApi.PersistanceLayer;
using Microsoft.Extensions.Logging;
using log4net.Repository.Hierarchy;
using log4net;
using System;

namespace AudreeBankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> logger;
        private ICustomerPersistance customerPersistance = null;

        public CustomerController(ILogger<CustomerController> logger, ICustomerPersistance customerPersistance) 
        {
            this.logger = logger;
            this.customerPersistance = customerPersistance;
        }

        [HttpPost]
        public IActionResult Post(Customer customer, int x)
        {            
            bool result = customerPersistance.Create(customer);
            this.logger.LogDebug("My first Log");
            return Created("", result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                this.logger.LogInformation("LogInformation: Reading data from DB started.");
                List<Customer> result = customerPersistance.Get();
                this.logger.LogInformation("LogInformation: Reading data Completed.");
                this.logger.LogDebug($"LogInformation: Results Resturned {result.Count}");
                return Ok(result);
            }
            catch(Exception ex)
            {               
                this.logger.LogError("LogError: Reading data from DB.");
                throw;
            }
        }
    }
}
