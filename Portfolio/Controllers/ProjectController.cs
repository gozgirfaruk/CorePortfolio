using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Business.ValitadionRules;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class ProjectController : Controller
    {
        ProjectMenager projectMenager = new ProjectMenager(new EfProjectDal());
        public IActionResult Index()
        {
            var values = projectMenager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var values = projectMenager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProject(Project project)
        {
            projectMenager.TUpdate(project);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(Project project)
        {
            ProjectValidator validationRules = new ProjectValidator();
            ValidationResult result = validationRules.Validate(project);
            if (result.IsValid)
            {
                project.Status = true;
                projectMenager.TAdd(project);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        public IActionResult DeleteProject(int id)
        {
            var values = projectMenager.GetById(id);
            projectMenager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult StatusChanger(int id)
        {
            var values = projectMenager.GetById(id);
            if (values.Status == true)
            {
                values.Status = false;
            }
            else
            {
                values.Status = true;
            }
            projectMenager.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
