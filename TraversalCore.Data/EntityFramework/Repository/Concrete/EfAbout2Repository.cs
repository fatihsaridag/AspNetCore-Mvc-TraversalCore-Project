using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Abstract;
using TraversalCore.Entity.Concrete;
using TraversalCore.Shared.Data.Repository;

namespace TraversalCore.Data.EntityFramework.Repository.Concrete
{
    public class EfAbout2Repository : GenericRepository<About2>, IAbout2Repository
    {
        public EfAbout2Repository(DbContext context) : base(context)
        {
        }
    }
}
