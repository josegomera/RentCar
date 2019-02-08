using RentCar.Bl.Results;
using RentCar.DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Repositories.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);  
        T Find(int id, params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        ActionResult<T> Add(T entity);
        ActionResult<T> SaveChanges();
        ActionResult<IEnumerable<T>> AddRange(IEnumerable<T> entity);
        ActionResult<T> Update(T entity);
        ActionResult<T> Remove(T entity);
    }
}
