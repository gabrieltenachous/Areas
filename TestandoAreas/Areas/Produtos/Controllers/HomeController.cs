 
using System.Diagnostics; 
using Microsoft.AspNetCore.Mvc;
using TestandoAreas.Models;

namespace TestandoAreas.Areas.Produtos.Controllers
{

    [Area("Produtos")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description areas.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact areas.";

            return View();
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
