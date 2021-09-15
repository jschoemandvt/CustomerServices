using CustomerServices.FrontEnd.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerServices.FrontEnd.Services
{
    public interface ICustomerClient
    {
        Task<IEnumerable<Customer>> GetDailyNewCustomers();
    }
}