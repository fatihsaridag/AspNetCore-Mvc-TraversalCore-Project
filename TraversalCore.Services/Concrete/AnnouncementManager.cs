using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Abstract;
using TraversalCore.Entity.Concrete;
using TraversalCore.Services.Abstract;

namespace TraversalCore.Services.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {

        private readonly IAnnouncementRepository _announcementRepository;

        public AnnouncementManager(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }


        public void TAdd(Announcement entity)
        {
            _announcementRepository.Insert(entity);
        }

        public void TDelete(Announcement entity)
        {
            _announcementRepository.Delete(entity);
        }

        public Announcement TGetById(int id)
        {
           return  _announcementRepository.GetById(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementRepository.GetList();
        }

        public void TUpdate(Announcement entity)
        {
            _announcementRepository.Update(entity);
        }
    }
}
