namespace Contracts.Features.Labels.Queries.GetLabels;

public readonly struct GetLabelsRequestDto
{
    public int Skip { get; init; }

    public int Take { get; init; }

    public string? SearchValue { get; init; }
}