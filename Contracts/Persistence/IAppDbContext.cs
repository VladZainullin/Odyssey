using Domain.Entities;

namespace Contracts.Persistence;

public interface IAppDbContext
{
    IRepository<User> Users { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}