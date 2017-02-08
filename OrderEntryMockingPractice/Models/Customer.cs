using OrderEntryMockingPractice.Services;

namespace OrderEntryMockingPractice.Models
{
    public class Customer
    {

        public ICustomerRepository _ICustomerRepository;

        public Customer(ICustomerRepository customerRepos)
        {
            _ICustomerRepository = customerRepos;
        }

        public Customer() { }

        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string EmailAddress { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}