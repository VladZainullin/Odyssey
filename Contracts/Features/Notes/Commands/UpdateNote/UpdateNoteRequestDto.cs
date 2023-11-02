namespace Contracts.Features.Notes.Commands.UpdateNote;

public readonly struct UpdateNoteRequestDto
{
    public required Guid Id { get; init; }
    
    public required string Body { get; init; }

    public required string Header { get; init; }
}