using Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

internal sealed class AppDbContextAdapter : IAppDbContext
{
    private readonly DbContext _context;

    public AppDbContextAdapter(DbContext context)
    {
        _context = context;
        
        Users = new Repository<User>(context);
    }
    
    public IRepository<User> Users { get; }
    
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}