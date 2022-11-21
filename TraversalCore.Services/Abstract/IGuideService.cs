using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Services.Abstract
{
    public interface IGuideService : IGenericService<Guide> 
    {
        void TChangeToTrueByGuide(int id);
        void TChangeToFalseByGuide(int id);
    }
}
