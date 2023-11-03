using MediatR;

namespace Contracts.Features.Labels.Commands.CreateLabel;

public sealed record CreateLabelRequest(CreateLabelRequestDto Dto) : IRequest<CreateLabelResponseDto>;