namespace Contracts.Features.Notes.Commands.DeleteNote;

public readonly struct DeleteNoteRequestDto
{
    public required Guid NoteId { get; init; }
}