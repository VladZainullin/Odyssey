namespace Domain.Entities;

public sealed class User
{
    public User(Guid id, string email, string passwordHash)
    {
        Email = email;
        PasswordHash = passwordHash;
    }
    
    public Guid Id { get; set; }

    public string Email { get; set; }

    public string PasswordHash { get; set; }
}