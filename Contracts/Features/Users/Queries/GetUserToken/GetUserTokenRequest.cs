using MediatR;

namespace Contracts.Features.Users.Queries.GetUserToken;

public sealed record GetUserTokenRequest(GetUserTokenRequestDto Dto) : IRequest<GetUserTokenResponseDto>;