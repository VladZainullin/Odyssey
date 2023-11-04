namespace Contracts.Persistence;

public interface IRepository<TEntity> : IQueryable<TEntity>
{
    Task AddAsync(TEntity entity, CancellationToken token);

    void Delete(TEntity entity);
}