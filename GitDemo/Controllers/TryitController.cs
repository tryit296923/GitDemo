using Microsoft.AspNetCore.Mvc;

namespace GitDemo.Controllers
{
    public class TryitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public string Hello()
        {

            return "Reds";
        }
        public string Eric()
        {
            return "Eric8888";

        }
    }
}
