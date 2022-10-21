using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class Home2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
