namespace Contracts.Features.Users.Queries.SignInUserToken;

public readonly struct SignInUserTokenResponseDto
{
    public required string Token { get; init; }
}