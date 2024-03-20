using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class ServiceController : Controller
    {
        ServiceMenager serviceMenager= new ServiceMenager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = serviceMenager.GetList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values = serviceMenager.GetById(id);
            serviceMenager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult InsertService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertService(Service service)
        {
            serviceMenager.TAdd(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id) 
        {
            var values = serviceMenager.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceMenager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
