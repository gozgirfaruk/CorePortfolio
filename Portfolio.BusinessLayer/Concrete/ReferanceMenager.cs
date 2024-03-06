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
    public class ReferanceMenager : IReferanceService
    {
        IReferanceDal _referanceDal;
        public ReferanceMenager(IReferanceDal referanceDal)
        {
            _referanceDal = referanceDal;
            
        }
        public Referance GetById(int id)
        {
            return _referanceDal.GetById(id);
        }

        public List<Referance> GetList()
        {
            return _referanceDal.GetList();
        }

        public void TAdd(Referance entity)
        {
            _referanceDal.Insert(entity);
        }

        public void TDelete(Referance entity)
        {
            _referanceDal.Delete(entity);
        }

        public void TUpdate(Referance entity)
        {
            _referanceDal.Update(entity);   
        }
    }
}
