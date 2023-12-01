using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppTest.Models;
using WebAppTest.Services;

namespace WebAppTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Service _service;

        public HomeController(ILogger<HomeController> logger, Service service)
        {
            _logger = logger;
            _service = service;
            _service.FillDatabase();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult App()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CheckLiterate()
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
