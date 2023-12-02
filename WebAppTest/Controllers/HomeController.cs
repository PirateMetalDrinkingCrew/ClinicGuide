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
        private MasterData _currentData = new MasterData();

        public HomeController(ILogger<HomeController> logger, Service service)
        {
            _logger = logger;
            _service = service;
            //_service.FillDatabase(); // Mit vorsicht genießen, sonst wird bei jedem klick diese funktion ausgeführt und die daten nochmal eingefügt. ein mal ausführen und dann auskommentieren
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
            //_currentData.lan
            return View();
        }

        public IActionResult Symptoms()
        {
            var anamnesisForm = _service.GetAnamnesisForm("french");
            var anamnesis = new Anamnesis();
            anamnesis.FeverLabel = anamnesisForm.Fever;
            anamnesis.HeadacheLabel = anamnesisForm.Headache;
            anamnesis.ColdLabel = anamnesisForm.Cold;
            anamnesis.CoughLabel = anamnesisForm.Cough;
            anamnesis.NasalSinusPainLabel = anamnesisForm.NasalSinusPain;
            anamnesis.EyePainLabel = anamnesisForm.EyePain;
            anamnesis.BoneFractureLabel = anamnesisForm.BoneFracture;
            anamnesis.SoreThroatLabel = anamnesisForm.SoreThroat;
            anamnesis.AbdominalPainLabel = anamnesisForm.AbdominalPain;
            anamnesis.LimbPainLabel = anamnesisForm.LimbPain;
            anamnesis.ElbowPainLabel = anamnesisForm.ElbowPain;
            anamnesis.HighBloodPressureLabel = anamnesisForm.HighBloodPressure;
            anamnesis.HeartAttackLabel = anamnesisForm.HeartAttack;
            anamnesis.StrokeLabel = anamnesisForm.Stroke;
            anamnesis.ThyroidDiseaseLabel = anamnesisForm.ThyroidDisease;
            anamnesis.DiabetesLabel = anamnesisForm.Diabetes;
            return View(anamnesis);
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
