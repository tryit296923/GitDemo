using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class HaileyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
