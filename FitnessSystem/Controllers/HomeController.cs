using FitnessSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FitnessSystem.Controllers
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

      
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Dashboard");
            }
            else
            {
                // If the model state is not valid, return the view with the same model to display validation errors
                return View("Contact", model);
            }
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Schedule()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NEWSLETTER()
        {
            return View();
        }
    }
}