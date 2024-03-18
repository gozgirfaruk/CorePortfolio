using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureMenager featureMenager = new FeatureMenager(new EfFeatureDal());
        public  IViewComponentResult Invoke()
        {
            var values = featureMenager.GetList();
            return View(values);
        }
    } 
}
