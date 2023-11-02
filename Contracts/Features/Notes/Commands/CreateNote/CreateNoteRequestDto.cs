namespace Contracts.Features.Notes.Commands.CreateNote;

public readonly struct CreateNoteRequestDto
{
    public required string Header { get; init; }

    public required string Body { get; init; }

    public required List<Guid> LabelIds { get; init; }
}