using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCCore6.Controllers
{
    public class ClientController1 : Controller
    {
        public IActionResult Index() //Action Json Content    "Iaction l interface"  "action des donnees"+result
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
