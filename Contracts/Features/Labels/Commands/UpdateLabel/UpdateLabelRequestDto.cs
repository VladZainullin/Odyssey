namespace Contracts.Features.Labels.Commands.UpdateLabel;

public readonly struct UpdateLabelRequestDto
{
    public required Guid Id { get; init; }

    public required string Title { get; init; }
}