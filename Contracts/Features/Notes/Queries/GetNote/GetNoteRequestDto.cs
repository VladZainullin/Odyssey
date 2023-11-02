namespace Contracts.Features.Notes.Queries.GetNote;

public readonly struct GetNoteRequestDto
{
    public required Guid NoteId { get; init; }
}