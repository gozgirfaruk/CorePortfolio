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
    public class UserMessageMenager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageMenager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public UserMessage GetById(int id)
        {
           return _userMessageDal.GetById(id);
        }

        public List<UserMessage> GetList()
        {
          return  _userMessageDal.GetList();
        }

      

        public void TAdd(UserMessage entity)
        { 
            _userMessageDal.Insert(entity);
        }

        public void TDelete(UserMessage entity)
        {
           _userMessageDal.Delete(entity);
        }

        public void TUpdate(UserMessage entity)
        {
           _userMessageDal.Update(entity);
        }

        public List<UserMessage> UserMessageWithUser()
        {
            return _userMessageDal.GetUserMessage();
        }
    }
}
