using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Entity.Concrete;
using TraversalCore.Shared.Data.Repository;

namespace TraversalCore.Data.EntityFramework.Repository.Abstract
{
    public interface INewsLetterRepository : IGenericRepository<Newsletter>
    {
    }
}
