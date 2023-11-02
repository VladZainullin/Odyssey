namespace Contracts.Features.Users.Commands.GetUserToken;

public readonly struct GetUserTokenResponseDto
{
    public required string Token { get; init; }
}