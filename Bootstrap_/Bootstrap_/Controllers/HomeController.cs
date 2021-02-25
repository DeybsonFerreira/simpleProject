using Bootstrap_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bootstrap_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dica1()
        {
            return View();
        }
        public IActionResult Dica2()
        {
            return View();
        }
        public IActionResult Dica3()
        {
            return View();
        }
        public IActionResult Dica4()
        {
            return View();
        }
        public IActionResult Dica5()
        {
            return View();
        }
        public IActionResult Dica6()
        {
            return View();
        }
        public IActionResult Dica7()
        {
            return View();
        }
        public IActionResult Dica8()
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
