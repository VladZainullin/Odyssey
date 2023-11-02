using MediatR;

namespace Contracts.Features.Users.Commands.CreateUser;

public sealed record CreateUserCommand(CreateUserRequestDto Dto) : IRequest<CreateUserResponseDto>;