namespace Contracts.Features.Labels.Queries.GetLabel;

public readonly struct GetLabelRequestDto
{
    public required Guid Id { get; init; }
}