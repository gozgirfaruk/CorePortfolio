﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potfolio.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetList();

        T GetById(int id);
    }
}
