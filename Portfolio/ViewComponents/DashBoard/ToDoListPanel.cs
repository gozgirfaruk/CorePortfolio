using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.DashBoard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListMenager listMenager=new ToDoListMenager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = listMenager.GetList();
            return View(values);
        }
    }
}
