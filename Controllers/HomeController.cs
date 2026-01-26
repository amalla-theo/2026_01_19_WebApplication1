using _2026_01_19_WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace _2026_01_19_WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }


        public IActionResult Lister()
        {
            LesPays pays = new LesPays();
            pays.ajouter();
            return View(pays);
        }


        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Edit(int Id)
        {
            LesPays pays = new LesPays();
            Pays p = new Pays();

            if (TempData["pays"] != null)
            {
                pays = JsonConvert.DeserializeObject<LesPays>(TempData["pays"].ToString());
                
                p = pays[Id - 1];
                TempData["pays"] = JsonConvert.SerializeObject(pays);
                TempData.Keep();
            }
            return View(p);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
