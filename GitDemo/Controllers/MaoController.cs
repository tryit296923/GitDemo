using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class MaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
