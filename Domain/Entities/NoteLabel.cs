namespace Domain.Entities;

public sealed class NoteLabel
{
    public NoteLabel(Note note, Label label)
    {
        Note = note;
        Label = label;
    }
    
    public Note Note { get; private set; }
    public Label Label { get; private set; }
}