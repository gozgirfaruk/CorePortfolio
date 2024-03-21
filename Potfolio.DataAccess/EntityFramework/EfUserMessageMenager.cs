using Microsoft.EntityFrameworkCore;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.Abstract;
using Potfolio.DataAccess.Concrete;
using Potfolio.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potfolio.DataAccess.EntityFramework
{
    public class EfUserMessageMenager : GenericRepository<UserMessage>, IUserMessageDal
    {
        List<UserMessage> IUserMessageDal.GetUserMessage()
        {
           using (var c= new Context())
            {
                return c.UserMessages.Include(x=>x.User).ToList();
            }
        }
    }
}
