using LinqSpecs;

namespace Domain.Entities;

public sealed class User
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private User()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        
    }
    
    public User(string username, string passwordHash) : this()
    {
        Username = username;
        PasswordHash = passwordHash;
    }

    public Guid Id { get; private init; } = Guid.NewGuid();

    public string Username { get; private set; }

    public string PasswordHash { get; private set; }
    
    public static class Spec
    {
        public static Specification<User> ByUsername(string username)
        {
            return new AdHocSpecification<User>(u => u.Username == username);
        }
    }
}