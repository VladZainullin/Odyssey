using MediatR;

namespace Contracts.Features.Labels.Queries.GetLabel;

public sealed record GetLabelRequest(GetLabelRequestDto Dto) : IRequest<GetLabelResponseDto>;