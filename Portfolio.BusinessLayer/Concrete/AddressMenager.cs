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
    public class AddressMenager : IAddressService
    {
        IAddressDal _addressDal;
        public AddressMenager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public Address GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public List<Address> GetList()
        {
          return _addressDal.GetList();
        }

        public void TAdd(Address entity)
        {
            _addressDal.Insert(entity);
        }

        public void TDelete(Address entity)
        {
            _addressDal.Delete(entity); 
        }

        public void TUpdate(Address entity)
        {
            _addressDal.Update(entity);
        }
    }
}
