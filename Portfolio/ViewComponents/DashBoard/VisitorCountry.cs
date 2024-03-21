using Microsoft.AspNetCore.Mvc;

namespace Portfolio.UI.ViewComponents.DashBoard
{
    public class VisitorCountry : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
