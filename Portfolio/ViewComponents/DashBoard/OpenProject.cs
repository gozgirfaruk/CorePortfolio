using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.DashBoard
{
    public class OpenProject : ViewComponent
    {
        ProjectMenager projectMenager = new ProjectMenager(new EfProjectDal());
        public IViewComponentResult Invoke()
        {
            var values = projectMenager.GetList();
            return View(values);
        }
    }
}
