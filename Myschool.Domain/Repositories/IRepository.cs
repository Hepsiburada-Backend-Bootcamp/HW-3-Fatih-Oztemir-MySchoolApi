using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Myschool.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task Add(TEntity entity);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
        Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter);
        Task<List<TEntity>> GetAll();
    }
}
