using Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

internal sealed class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}