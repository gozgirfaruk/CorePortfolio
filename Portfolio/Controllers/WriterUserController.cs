using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class WriterUserController : Controller
    { 
        DenemeMenager menager = new DenemeMenager(new EfDenemeDal());
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(menager.GetList());
            return View(values);    
        }

        [HttpPost]
        public IActionResult AddUser(WriterUser p)
        {
            menager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);

        }
    }
}
