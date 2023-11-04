using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

internal sealed class UserRepository : Repository<User>
{
    public UserRepository(DbContext context) : base(context)
    {
    }
}