using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCCore6.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2Controller

        [Route("testn")]
        public IActionResult Index()
        {
            ViewData["age2"] = TempData["age"];
            //TempData.Keep();
            return View();
        }
    }
}
