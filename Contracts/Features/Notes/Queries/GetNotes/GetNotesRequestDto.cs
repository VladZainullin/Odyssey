namespace Contracts.Features.Notes.Queries.GetNotes;

public readonly struct GetNotesRequestDto
{
    public int Skip { get; init; }

    public int Take { get; init; }
}