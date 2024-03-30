using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;

namespace Portfolio.UI.Areas.Writer.ViewComponents
{
    public class NavbarProfile : ViewComponent
    {
        private readonly UserManager<WriterUser> _userMenager;

        public NavbarProfile(UserManager<WriterUser> userMenager)
        {
            _userMenager = userMenager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userMenager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.ImageUrl;
            return View();
        }
    }
}
