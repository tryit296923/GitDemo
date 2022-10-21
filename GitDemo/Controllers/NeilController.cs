using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class NeilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
