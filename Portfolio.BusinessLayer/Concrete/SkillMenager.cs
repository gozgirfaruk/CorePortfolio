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
    public class SkillMenager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillMenager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        public Skill GetById(int id)
        {
            return _skillDal.GetById(id);   
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetList();
        }

        public void TAdd(Skill entity)
        {
            _skillDal.Insert(entity);
        }

        public void TDelete(Skill entity)
        {
           _skillDal.Delete(entity);
        }

        public void TUpdate(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
