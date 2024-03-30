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
    public class WriterMessageMenager : IWriterMessageService
    {
        IWriterMessageDal _wmDal;

        public WriterMessageMenager(IWriterMessageDal wmDal)
        {
            _wmDal = wmDal;
        }

        public WriterMessage GetById(int id)
        {
           return _wmDal.GetById(id);
        }

        public List<WriterMessage> GetList()
        {
            return _wmDal.GetList();
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return  _wmDal.GetbyFilter(x=>x.Receiver==p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _wmDal.GetbyFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage entity)
        {
           _wmDal.Insert(entity);
        }

        public void TDelete(WriterMessage entity)
        {
            _wmDal.Delete(entity);
        }

        public void TUpdate(WriterMessage entity)
        {
            _wmDal.Update(entity);
        }
    }
}
