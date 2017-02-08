

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using NSubstitute;
using OrderEntryMockingPractice.Models;
using OrderEntryMockingPractice.Services;
using Shouldly;

namespace OrderEntryMockingPracticeTests
{
    [TestFixture]
    public class OrderServiceTests
    {

        // test = Customer Information can be retrieved from the Customer Repository 
        [Test]
        public void CustomerInformation_CanBeRetrievedFromCustomerRepository()
        {
            ICustomerRepository custRepository = Substitute.For<ICustomerRepository>();

            var cust = new Customer(custRepository);

            string name = "test name";

            cust.CustomerName = name;

            string returnName = cust.CustomerName;

            //Customer cust = new Customer(custRepository);
            Assert.AreEqual("test name", returnName);
        }

    }
}
