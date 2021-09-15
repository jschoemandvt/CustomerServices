using CustomerServices.CustomerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerServices.CustomerApi.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static readonly string[] DailyNewCustomers = new[]
        {
            "Tania Weldon",
            "Joseph Rivers",
            "Harmony Michael",
            "Chris Hall",
            "Adalie Weasley",
            "Marie Zaoui",
            "Daphne Thatcher",
            "Lara Kaur",
            "Hayden Hepburn",
            "Liliana Rowan",
            "Alan Carter",
            "Phillip Broomfield",
            "Makena Mould",
            "Jack Broomfield",
            "Isabella Upsdell",
            "Mackenzie Fisher",
            "Caydence Ring",
            "Lily Corbett",
            "Davina Dann",
            "John Hilton"
        };

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("dailynewcustomers")]
        public IEnumerable<Customer> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Customer
            {
                CreatedDate = DateTime.Now,
                CustomerId = Guid.NewGuid(),
                FullName = DailyNewCustomers[rng.Next(DailyNewCustomers.Length)]
            })
            .ToArray();
        }
    }
}