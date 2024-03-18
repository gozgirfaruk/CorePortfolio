using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Project
{
    public class ProjectList : ViewComponent
    {
        ProjectMenager projectMenager = new ProjectMenager(new EfProjectDal());
        public IViewComponentResult Invoke()
        {
            var values = projectMenager.GetList();
            return View(values);
        }
    }
}
