﻿using Portfolio.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Business.Abstract
{
    public interface IUserMessageService : IGenericService<UserMessage>
    {
        List<UserMessage> UserMessageWithUser();
    }
}
