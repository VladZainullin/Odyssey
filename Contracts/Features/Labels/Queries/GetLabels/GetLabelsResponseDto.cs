namespace Contracts.Features.Labels.Queries.GetLabels;

public readonly struct GetLabelsResponseDto
{
    public required IEnumerable<LabelDto> Values { get; init; }

    public required int TotalCount { get; init; }
    
    public readonly struct LabelDto
    {
        public required Guid Id { get; init; }

        public required string Title { get; init; }
    }
}