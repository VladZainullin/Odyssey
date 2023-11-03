using MediatR;

namespace Contracts.Features.Labels.Commands.UpdateLabel;

public sealed record UpdateLabelRequest(UpdateLabelRequestDto Dto) : IRequest<UpdateLabelResponseDto>;