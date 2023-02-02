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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsRepository _contactUsRepository;

        public ContactUsManager(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            _contactUsRepository.ContactUsStatusChangeToFalse(id);
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            var contactUsByFalse = _contactUsRepository.GetListContactUsByFalse();
            return contactUsByFalse;
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            var contactUsByTrue = _contactUsRepository.GetListContactUsByTrue();
            return contactUsByTrue;
        }

        public void TAdd(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetList()
        {
            var contactUsList = _contactUsRepository.GetList();
            return contactUsList;
        }

        public void TUpdate(ContactUs entity)
        {
            throw new NotImplementedException();
        }
    }
}
