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
    public class DenemeMenager : IDenemeService
    {
        IDenemeDal _denemeDal;

        public DenemeMenager(IDenemeDal denemeDal)
        {
            _denemeDal = denemeDal;
        }

        public WriterUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> GetList()
        {
            return _denemeDal.GetList();
        }

        public void TAdd(WriterUser entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterUser entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
