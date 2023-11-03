namespace Contracts.Features.Notes.Queries.GetNotes;

public readonly struct GetNotesRequestDto
{
    public required int Skip { get; init; }

    public required int Take { get; init; }

    public required string SearchValue { get; init; }
}