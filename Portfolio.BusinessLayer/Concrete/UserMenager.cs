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
    public class UserMenager : IUserService
    {
        IUserDal _userDal;

        public UserMenager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetById(int id)
        {
           return _userDal.GetById(id);
        }

        public List<User> GetList()
        {
            return _userDal.GetList();
        }

        public void TAdd(User entity)
        {
            _userDal.Insert(entity);
        }

        public void TDelete(User entity)
        {
            _userDal.Delete(entity);
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
