using NorthwindBlazor.Lib.Models.Entity;

namespace NorthwindBlazor.App.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly NorthwindContext _context;

        public CustomerService(NorthwindContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(string customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            return _context.Customers;
        }
    }
}
