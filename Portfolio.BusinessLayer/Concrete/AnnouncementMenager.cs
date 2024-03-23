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
    public class AnnouncementMenager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementMenager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> GetList()
        {
            return  _announcementDal.GetList();
        }

        public void TAdd(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement entity)
        {
            throw new NotImplementedException();
        }
    }
}
