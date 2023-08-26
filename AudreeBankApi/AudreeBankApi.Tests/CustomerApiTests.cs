using System;
using Xunit;
using AudreeBankApi.Controllers;
using AudreeBankApi.PersistanceLayer;
using Microsoft.AspNetCore.Mvc;
using AudreeBankApi.PersistanceLayer.EFDataContext;
using System.Collections.Generic;
using Moq;


namespace AudreeBankApi.Tests
{
    public class CustomerApiTests
    {
        public Mock<ICustomerPersistance> mockRepository = new Mock<ICustomerPersistance>();

        [Fact]
        public void get_customer_should_return_customer_object()
        {
            //Arrange
            List<Customer> customerList = new List<Customer>();
            mockRepository.Setup(customerRepo => customerRepo.Get()).Returns(customerList);
            CustomerController customerController = new CustomerController(mockRepository.Object);

            // Act
            OkObjectResult result = customerController.Get() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal<int>(200, result.StatusCode.Value);
        }

        [Fact]
        public void get_customer_should_return_customer_list_of_size_4()
        {
            //Arrange
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer { Name = "Ravi", City = "Hyderabad", DoB = DateTime.Today, Id = 1 });
            customerList.Add(new Customer { Name = "Ravi", City = "Hyderabad", DoB = DateTime.Today, Id = 1 });
            customerList.Add(new Customer { Name = "Ravi", City = "Hyderabad", DoB = DateTime.Today, Id = 1 });
            customerList.Add(new Customer { Name = "Ravi", City = "Hyderabad", DoB = DateTime.Today, Id = 1 });

            mockRepository.Setup(customerRepo => customerRepo.Get()).Returns(customerList);
            CustomerController customerController = new CustomerController(mockRepository.Object);

            // Act
            OkObjectResult result = customerController.Get() as OkObjectResult;

            // Assert
            List<Customer> data = result.Value as List<Customer>;
            Assert.Equal(4, data.Count);
        }
    }
}
