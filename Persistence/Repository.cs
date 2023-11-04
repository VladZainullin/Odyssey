using System.Collections;
using System.Linq.Expressions;
using Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbSet<TEntity> _set;

    protected Repository(DbContext context)
    {
        _set = context.Set<TEntity>();
    }
    
    public Type ElementType => ((IQueryable<TEntity>)_set).ElementType;
    public Expression Expression => ((IQueryable<TEntity>)_set).Expression;
    public IQueryProvider Provider => ((IQueryable<TEntity>)_set).Provider;
    public IEnumerator<TEntity> GetEnumerator() => ((IEnumerable<TEntity>)_set).GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<TEntity>)_set).GetEnumerator();
    
    public async Task AddAsync(TEntity entity, CancellationToken token)
    {
        await _set.AddAsync(entity, token);
    }

    public void Delete(TEntity entity)
    {
        _set.Remove(entity);
    }
}
