namespace Domain.Entities;

public sealed class Label
{
    public Label(string title, User user)
    {
        Title = title;
        User = user;
    }

    public Guid Id { get; private init; } = Guid.NewGuid();
    
    public string Title { get; private set; }
    
    public User User { get; private set; }
}