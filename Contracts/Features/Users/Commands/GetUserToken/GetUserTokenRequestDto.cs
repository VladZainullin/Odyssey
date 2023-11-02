namespace Contracts.Features.Users.Commands.GetUserToken;

public readonly struct GetUserTokenRequestDto
{
    public required string Email { get; init; }

    public required string Password { get; init; }
}