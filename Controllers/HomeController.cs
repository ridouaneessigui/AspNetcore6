using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppCoreMvc.Models;

namespace WebAppCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            //ViewData["nom"] = "clil";
            //ViewData["message"] = "bonjour";
                      //ViewBag.nom = "clil";
                     //ViewBag.message = "bonjour";
            TempData["age"] = "test data";
            var data = TempData["age"];
            ViewData["age"] = data;
            TempData.Keep();
            return View();
        }

       

        [Route("test1")]
        public IActionResult Test1()
        {
            ViewData["age3"] = TempData["age"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("welcom")]

        public JsonResult Welcome()
        {
            bool isAdmin = false;
            string output = isAdmin ? "Welcome to the Admin User" : "Welcome to the User";



            return Json(output);



        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}