using System.Collections.Generic;
using System.Threading.Tasks;
using Msq.Specification;

namespace Msq.Repository
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        TEntity Get(object entityId);
        Task<TEntity> GetAsync(object entityId);
        void Add(TEntity entity);
        Task AddAsync(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task UpdateRangeAsync(IEnumerable<TEntity> entities);
        void Delete(object entityId);
        Task DeleteAsync(object entityId);
        IList<TEntity> FindBy(ISpecification<TEntity> specification);
        Task<IList<TEntity>> FindByAsync(ISpecification<TEntity> specification);
        TEntity FindFirstOrDefaultBy(ISpecification<TEntity> specification);
        Task<TEntity> FindFirstOrDefaultByAsync(ISpecification<TEntity> specification);
        TEntity FindOneBy(ISpecification<TEntity> specification);
        Task<TEntity> FindOneByAsync(ISpecification<TEntity> specification);
        IList<TEntity> GetAll();
        Task<IList<TEntity>> GetAllAsync();
    }
}
