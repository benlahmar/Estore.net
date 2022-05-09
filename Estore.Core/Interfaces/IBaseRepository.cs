using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estore.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        public T add(T entity);
        public T remove(T entity);
        public T findById(int id);
        public IEnumerable<T> GetAll();
        public IQueryable<T> findByCondition(Func<Exception, bool> condition);
        public IQueryable Query { get; }

        
    }
}
