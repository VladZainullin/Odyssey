namespace Domain.Entities;

public sealed class NoteLabel
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private NoteLabel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        
    }
    
    public NoteLabel(Note note, Label label) : this()
    {
        Note = note;
        Label = label;
    }
    
    public Note Note { get; private set; }
    public Label Label { get; private set; }
}