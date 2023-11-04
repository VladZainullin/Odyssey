namespace Domain.Entities;

public sealed class User
{
    public User(string username, string passwordHash)
    {
        Username = username;
        PasswordHash = passwordHash;
    }

    public Guid Id { get; private init; } = Guid.NewGuid();

    public string Username { get; private set; }

    public string PasswordHash { get; private set; }
}