using NorthwindBlazor.Lib.Models.Entity;

namespace NorthwindBlazor.App.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomerList();
        Task<Customer> GetCustomerById(string customerId);
    }
}