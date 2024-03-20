using Portfolio.Business.Abstract;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Business.Concrete
{
    public class ProjectMenager : IProjectService
    {
        IProjectDal _projectDal;
        public ProjectMenager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }
        public Project GetById(int id)
        {
           return _projectDal.GetById(id);
        }

        public List<Project> GetList()
        {
            return _projectDal.GetList();
        }

        public void TAdd(Project entity)
        {
            _projectDal.Insert(entity);
        }

        public void TDelete(Project entity)
        {
            _projectDal.Delete(entity);
        }

        public void TUpdate(Project entity)
        {
            _projectDal.Update(entity); 
        }

    }
}
