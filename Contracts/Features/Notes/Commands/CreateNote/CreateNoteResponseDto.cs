namespace Contracts.Features.Notes.Commands.CreateNote;

public readonly struct CreateNoteResponseDto
{
    public required Guid Id { get; init; }
}