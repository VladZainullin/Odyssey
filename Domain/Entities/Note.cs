namespace Domain.Entities;

public sealed class Note
{
    public Note(string header, string body, User user)
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