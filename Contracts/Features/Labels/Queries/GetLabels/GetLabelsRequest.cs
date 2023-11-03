using MediatR;

namespace Contracts.Features.Labels.Queries.GetLabels;

public sealed record GetLabelsRequest(GetLabelsRequestDto Dto) : IRequest<GetLabelsResponseDto>;