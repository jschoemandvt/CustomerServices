using CustomerServices.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CustomerServices.FrontEnd.Services
{
    public class CustomerClient : ICustomerClient
	{
		private HttpClient _httpClient;

		public CustomerClient(HttpClient httpClient)
		{
			this._httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
		}

		public async Task<IEnumerable<Customer>> GetDailyNewCustomers()
		{
			return await _httpClient.
				GetFromJsonAsync<IEnumerable<Customer>>("/dailynewcustomers");
		}
	}
}