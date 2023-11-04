namespace Contracts.Persistence;

public interface IRepository<out TEntity> : IQueryable<TEntity>
{
    
}