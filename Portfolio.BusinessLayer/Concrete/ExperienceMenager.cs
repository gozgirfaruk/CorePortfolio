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
    public class ExperienceMenager : IExperienceService
    {
        IExperienceDal _experienceDal;
        public ExperienceMenager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public Experience GetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<Experience> GetList()
        {
            return _experienceDal.GetList();
        }

        public void TAdd(Experience entity)
        {
            _experienceDal.Insert(entity);
        }

        public void TDelete(Experience entity)
        {
           _experienceDal.Delete(entity);
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
