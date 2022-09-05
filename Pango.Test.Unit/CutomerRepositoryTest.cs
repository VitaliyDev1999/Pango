using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pango.Domain.Entities;
using Pango.Domain.Interfaces;
using Pango.Infrastructure;
using Pango.Infrastructure.Repositories;
using System;
using System.Linq;

namespace Pango.Test.Unit
{
    [TestClass]
    public class CutomerRepositoryTest
    {
        private PangoContext _dbContext;
        private ICustomerRepository _customerRepository;

        [TestInitialize]
        public void Initialize()
        {
            SetupDbContext();

            _customerRepository = new CustomerRepository(_dbContext);
        }

        private void SetupDbContext()
        {
            _dbContext = new MemoryDbContext();

            _dbContext.Set<Customer>().Add(new Customer()
            {
                Id = Guid.NewGuid(),
                Email = "deineha1@gmail.com",
                FirstName = "Vitalii",
                LastName = "Deineha",
                PhoneNumber = "096321456"
            });
            _dbContext.Set<Customer>().Add(new Customer()
            {
                Id = Guid.NewGuid(),
                Email = "deineha2@gmail.com",
                FirstName = "Vitalii",
                LastName = "Deineha",
                PhoneNumber = "096321456"
            });
            _dbContext.Set<Customer>().Add(new Customer()
            {
                Id = Guid.NewGuid(),
                Email = "deineha3@gmail.com",
                FirstName = "Vitalii",
                LastName = "Deineha",
                PhoneNumber = "096321456"
            });

            _dbContext.SaveChanges();
        }

        [TestMethod]
        public void GetCutomersSuccessfully_ReturnsListOfCustomers()
        {
            var customersCount = 3;

            var result = _customerRepository.GetAllCustomersAsync().GetAwaiter().GetResult().ToList();

            Assert.IsNotNull(result);
            Assert.AreEqual(customersCount, result.Count);
        }
    }
}