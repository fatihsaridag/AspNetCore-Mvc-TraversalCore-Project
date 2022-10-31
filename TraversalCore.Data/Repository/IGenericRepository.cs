using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCore.Data.Repository
{
    public interface IGenericRepository<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
