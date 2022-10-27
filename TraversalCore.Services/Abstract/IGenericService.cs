using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCore.Services.Abstract
{
    public interface IGenericService<TEntity>
    {
        void TAdd(TEntity entity);
        void TDelete(TEntity entity);
        void TUpdate(TEntity entity);
        List<TEntity> TGetList();
        TEntity TGetById(int id);
    }
}
