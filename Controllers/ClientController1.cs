using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCCore6.Controllers
{
    public class ClientController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
