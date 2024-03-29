using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
