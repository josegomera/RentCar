using EntityFramework.DynamicFilters;
using FluentValidation;
using RentCar.Bl.Extensions;
using RentCar.Bl.Results;
using RentCar.DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Repositories.Base.Implementation
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext _context;
        public DbSet<T> _set;
        public IValidator<T> _validator;

        public EntityBaseRepository(DbContext context, IValidator<T> validator)
        {
            _context = context;
            _set = context.Set<T>();
            _validator = validator;
        }

        public virtual ActionResult<T> Add(T entity)
        {
            var results = _validator.Validate(entity);
            if (results.IsValid)
            {
                var entry = _set.Add(entity);
                return new ActionResult<T>() { Result = entity, Success = true };
            }
            var errosMsg = results.Errors.ToMessage();
            return new ActionResult<T>() {  Message = errosMsg };
        }

        public virtual ActionResult<IEnumerable<T>> AddRange(IEnumerable<T> entityEnumerable)
        {

            foreach (var ent in entityEnumerable)
            {
                var results = _validator.Validate(ent);
                if (!results.IsValid)
                {
                    var errosMsg = results.Errors.ToMessage();
                    return new ActionResult<IEnumerable<T>>() { Message = errosMsg };
                }
            }

            _set.AddRange(entityEnumerable);
            return new ActionResult<IEnumerable<T>>() { Result = entityEnumerable, Success = true };
        }

        public virtual T Find(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _set.AsQueryable();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public virtual IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _set.Where(predicate);
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.AsNoTracking().ToList();
        }

        public virtual IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _set.AsQueryable();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return  query.ToList();
        }

        public virtual ActionResult<T> Remove(T entity)
        {
            DbEntityEntry dbEntityEntry = _context.Entry(entity);
            entity.IsDeleted = true;
            dbEntityEntry.State = EntityState.Modified;
            return new ActionResult<T>() { Success = true };
        }

        public virtual ActionResult<T> Update(T entity)
        {
            var results = _validator.Validate(entity);
            if (results.IsValid)
            {
                DbEntityEntry dbEntityEntry = _context.Entry(entity);
                dbEntityEntry.State = EntityState.Modified;
                return new ActionResult<T>() { Result = entity, Success = true };
            }
            var errosMsg = results.Errors.ToMessage();
            return new ActionResult<T>() { Message = errosMsg };
        }

        public virtual ActionResult<T> SaveChanges()   
        {
            try
            {
                 _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                return new ActionResult<T>() { Message = ex.Message };
                //Log the error (uncomment ex variable name and write a log.)
                //ModelState.AddModelError("", "Unable to save changes. " +
                //"Try again, and if the problem persists, " +
                // "see your system administrator.");
            }
            return new ActionResult<T>() { Success = true };
        }

        public virtual void DisableFilter(string value)
        {
            _context.DisableFilter(value);
        }
    }
}
