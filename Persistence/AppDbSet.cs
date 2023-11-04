using Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Persistence;

#pragma warning disable EF1001
internal sealed class AppDbSet<T> : InternalDbSet<T> where T : class, IRepository<T>
#pragma warning restore EF1001
{
#pragma warning disable EF1001
    public AppDbSet(DbContext context, string? entityTypeName) : base(context, entityTypeName)
#pragma warning restore EF1001
    {
    }
}
