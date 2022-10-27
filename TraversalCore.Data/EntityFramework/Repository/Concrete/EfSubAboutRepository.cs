using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Abstract;
using TraversalCore.Data.Repository;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Data.EntityFramework.Repository.Concrete
{
    public class EfSubAboutRepository : GenericRepository<SubAbout>, ISubAboutRepository
    {
        
    }
}
