namespace Contracts.Features.Labels.Queries.GetLabels;

public readonly struct GetLabelsResponseDto
{
    public required Guid Id { get; init; }

    public required string Title { get; init; }
}