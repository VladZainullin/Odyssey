namespace Contracts.Features.Notes.Queries.GetNotes;

public readonly struct GetNotesResponseDto
{
    public required IEnumerable<NoteDto> Notes { get; init; }

    public required int TotalCount { get; init; }
    
    public readonly struct NoteDto
    {
        public required Guid Id { get; init; }

        public required string Header { get; init; }

        public required string Body { get; init; }
    }
}