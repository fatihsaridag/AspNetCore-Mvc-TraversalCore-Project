using Microsoft.EntityFrameworkCore;
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
    public class EfGuideRepository : GenericRepository<Guide>, IGuideRepository
    {
        Context context = new Context();

        public void ChangeToFalseByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
