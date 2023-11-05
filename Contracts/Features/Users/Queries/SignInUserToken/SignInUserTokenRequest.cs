using MediatR;

namespace Contracts.Features.Users.Queries.SignInUserToken;

public sealed record SignInUserTokenRequest(SignInUserTokenRequestDto Dto) : IRequest<SignInUserTokenResponseDto>;