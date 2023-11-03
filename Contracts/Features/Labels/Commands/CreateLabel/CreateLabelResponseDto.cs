namespace Contracts.Features.Labels.Commands.CreateLabel;

public readonly struct CreateLabelResponseDto
{
    public required Guid LabelId { get; init; }
}