using NorthwindBlazor.Lib.Models.Entity;

namespace NorthwindBlazor.App.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomerList();
        IEnumerable<Customer> GetCustomerList(string customerName);
        Task<Customer> GetCustomerById(string customerId);
    }
}