using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Products")]
        public IActionResult Items()
        {
            return View("tovary");
        }
    }
}
