using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Contexts;
using TraversalCore.Data.EntityFramework.Repository.Abstract;
using TraversalCore.Data.Repository;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Data.EntityFramework.Repository.Concrete
{
    public class EfContactUsRepository : GenericRepository<ContactUs>, IContactUsRepository
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using(var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }
    }
}
