namespace Contracts.Features.Labels.Queries.GetLabels;

public readonly struct GetLabelsRequestDto
{
    public required Guid Id { get; init; }
}