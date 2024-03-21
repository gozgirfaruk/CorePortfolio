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
    public class ToDoListMenager : IToDoListService
    {
        IToDoListDal _todoListDal;

        public ToDoListMenager(IToDoListDal todoListDal)
        {
            _todoListDal = todoListDal;
        }

        public ToDoList GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> GetList()
        {
            return _todoListDal.GetList();
        }

        public void TAdd(ToDoList entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ToDoList entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDoList entity)
        {
            throw new NotImplementedException();
        }
    }
}
