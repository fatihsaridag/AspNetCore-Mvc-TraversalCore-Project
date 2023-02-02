using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.Repository;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Data.EntityFramework.Repository.Abstract
{
    public interface IContactUsRepository : IGenericRepository<ContactUs>
    {
        List<ContactUs> GetListContactUsByTrue();
        List<ContactUs> GetListContactUsByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
