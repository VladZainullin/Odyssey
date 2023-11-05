namespace Contracts.Features.Users.Queries.SignInUserToken;

public readonly struct SignInUserTokenRequestDto
{
    public required string Username { get; init; }

    public required string Password { get; init; }
}