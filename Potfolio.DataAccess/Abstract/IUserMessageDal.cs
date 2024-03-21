using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potfolio.DataAccess.Abstract
{
    public interface IUserMessageDal : IGenericDal<UserMessage>
    {
        public List<UserMessage> GetUserMessage();
    }
}
