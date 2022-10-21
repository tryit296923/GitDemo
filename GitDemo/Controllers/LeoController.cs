using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class LeoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
