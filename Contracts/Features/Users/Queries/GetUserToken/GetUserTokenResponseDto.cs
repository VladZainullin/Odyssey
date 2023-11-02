namespace Contracts.Features.Users.Queries.GetUserToken;

public readonly struct GetUserTokenResponseDto
{
    public required string Token { get; init; }
}