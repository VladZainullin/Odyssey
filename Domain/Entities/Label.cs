namespace Domain.Entities;

public sealed class Label
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Label()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        
    }
    
    public Label(string title, User user) : this()
    {
        Title = title;
        User = user;
    }

    public Guid Id { get; private init; } = Guid.NewGuid();
    
    public string Title { get; private set; }
    
    public User User { get; private set; }
}