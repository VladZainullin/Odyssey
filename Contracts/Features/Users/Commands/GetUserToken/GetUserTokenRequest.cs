using MediatR;

namespace Contracts.Features.Users.Commands.GetUserToken;

public sealed record GetUserTokenRequest(GetUserTokenRequestDto Dto) : IRequest<GetUserTokenResponseDto>;