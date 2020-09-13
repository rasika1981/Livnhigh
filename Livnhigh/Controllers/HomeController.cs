using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Livnhigh.Models;
using Microsoft.Azure.Cosmos.Table;

namespace Livnhigh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(NoStore = true, Duration = 0, Location = ResponseCacheLocation.None)]
        public IActionResult Index()
        {
            return View();
        }

        public void JoinClub()
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=60b0852e-85cc-453a-8391-d65287dd5cf6;AccountKey=teIETYBhKzJ8aPdsl3By1ZlnlvZCAVWbdlqhuK9dXoc249xy7QhY0HHAlz9gBiB4cXgcB7aMi12zYsgyuSozkg==;TableEndpoint=https://60b0852e-85cc-453a-8391-d65287dd5cf6.table.cosmos.azure.com:443/;";
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
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
