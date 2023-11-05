namespace Domain.Entities;

public sealed class Note
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Note()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        
    }
    
    public Note(string header, string body, User user) : this()
    {
        Header = header;
        Body = body;
        User = user;
    }

    public Guid Id { get; private init; } = Guid.NewGuid();
    
    public string Header { get; private set; }
    public string Body { get; private set; }
    public User User { get; private set; }
}