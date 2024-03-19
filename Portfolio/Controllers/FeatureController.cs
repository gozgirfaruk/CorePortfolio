using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
