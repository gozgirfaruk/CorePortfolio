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
    public class SocialMenager : ISocialService
    {
        ISocialDal _socialDal;
        public SocialMenager(ISocialDal socialDal)
        {
            _socialDal = socialDal;   
        }
        public Social GetById(int id)
        {
           return _socialDal.GetById(id);
        }

        public List<Social> GetList()
        {
            return _socialDal.GetList();
        }

        public void TAdd(Social entity)
        {
            _socialDal.Insert(entity);
        }

        public void TDelete(Social entity)
        {
            _socialDal.Delete(entity);
        }

        public void TUpdate(Social entity)
        {
            _socialDal.Update(entity);
        }
    }
}
