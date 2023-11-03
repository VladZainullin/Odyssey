namespace Contracts.Features.Labels.Queries.GetLabel;

public readonly struct GetLabelResponseDto
{
    public required Guid Id { get; init; }

    public required string Title { get; init; }
}