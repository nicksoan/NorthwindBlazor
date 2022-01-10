using NorthwindBlazor.Lib.Models.Entity;

namespace NorthwindBlazor.App.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomerList();
        Customer GetCustomerById(string customerId);
    }
}