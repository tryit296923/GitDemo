using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class LukaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
