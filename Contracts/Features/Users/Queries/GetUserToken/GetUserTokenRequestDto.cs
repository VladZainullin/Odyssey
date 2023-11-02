namespace Contracts.Features.Users.Queries.GetUserToken;

public readonly struct GetUserTokenRequestDto
{
    public required string Email { get; init; }

    public required string Password { get; init; }
}