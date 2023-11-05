using MediatR;

namespace Contracts.Features.Users.Commands.SignUpUser;

public sealed record SignUpUserCommand(SignUpUserRequestDto Dto) : IRequest<SignUpUserResponseDto>;