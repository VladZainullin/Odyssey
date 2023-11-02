namespace Contracts.Features.Notes.Commands.UpdateNote;

public readonly struct UpdateNoteResponseDto
{
    public required Guid NoteId { get; init; }
}