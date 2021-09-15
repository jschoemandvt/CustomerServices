using CustomerServices.FrontEnd.Models;
using CustomerServices.FrontEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerServices.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerClient _customerClient;

        public HomeController(ILogger<HomeController> logger, ICustomerClient customerClient)
        {
            _logger = logger;
            _customerClient = customerClient;
        }

        public async Task<IActionResult> Index()
        {
            //logging info
            _logger.LogInformation("Entered the index method in FrontEnd");

            var data = await _customerClient.GetDailyNewCustomers();

            _logger.LogInformation($"Return data {JsonSerializer.Serialize(data)}");

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}