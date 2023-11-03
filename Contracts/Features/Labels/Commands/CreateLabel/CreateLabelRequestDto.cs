namespace Contracts.Features.Labels.Commands.CreateLabel;

public readonly struct CreateLabelRequestDto
{
    public required string Title { get; init; }
}