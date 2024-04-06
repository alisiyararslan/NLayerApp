using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        /*
         Update ve Remove : Service class'larında UnitOfWork'ün   CommitAsync methodunu çağırdığımız için asenkron olarak tanımladık. UnitOfWork'ün CommitAsync methouda dbcontext'in  SaveChangeAsync methodunu çağırmaktadır.  Mümkün olduğunda her  zaman asenkron methodları kullanmamız gerekir. Bu sebeple service katmanında asenkron yaptık repo katmanında   update ve remove methodlarının  asenkron halleri olmadığı için çağırmadık.
         */
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
