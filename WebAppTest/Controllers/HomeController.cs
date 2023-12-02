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
            _service.FillDatabase(); // Mit vorsicht genießen, sonst wird bei jedem klick diese funktion ausgeführt und die daten nochmal eingefügt. ein mal ausführen und dann auskommentieren
            _service.ReadDataBase();
        }

        public IActionResult Index()
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

        public IActionResult Symptoms()
        {
            return View();
        }

        public IActionResult SymptomsPictures()
        {
            return View();
        }

        public IActionResult SubmitSymptoms()
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
