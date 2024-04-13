using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Feature
{
    public class FeatureSocial : ViewComponent
    {
        SocialMenager socialMenager = new SocialMenager(new EfSocialDal());
        public IViewComponentResult Invoke()
        {
            var values = socialMenager.GetList();
            return View(values);
        }
    }
}
