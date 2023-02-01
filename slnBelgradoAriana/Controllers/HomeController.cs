using Microsoft.AspNetCore.Mvc;

namespace slnBelgradoAriana.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
