namespace Contracts.Features.Notes.Queries.GetNote;

public readonly struct GetNoteResponseDto
{
    public required Guid Id { get; init; }

    public required string Header { get; init; }

    public required string Body { get; init; }
}