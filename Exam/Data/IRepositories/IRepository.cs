using Exam.Domain.Configuration;

namespace Exam.Data.IRepositories;

public interface IRepository<TEntity>
{
    Task<TEntity> InsertAsync(TEntity entity);
    Task<TEntity> ModifyAsync(TEntity entity);
    Task<bool> RemoveAsync(long id);
    Task<TEntity> SelectByIdAsync(long id);
    Task<IEnumerable<TEntity>> SelectAllAsync();
}
