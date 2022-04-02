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

        public async Task<Customer> GetCustomerById(string customerId)
        {
            return await _context.Customers.FindAsync(customerId);
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            return _context.Customers;
        }

        public IEnumerable<Customer> GetCustomerList(string customerName)
        {
            return GetCustomerListByName(customerName);
        }

        //search customers by name
        public IEnumerable<Customer> GetCustomerListByName(string name)
        {
            return _context.Customers.Where(c => c.CompanyName.Contains(name));
        }

    }
}
