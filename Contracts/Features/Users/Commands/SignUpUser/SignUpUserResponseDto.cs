namespace Contracts.Features.Users.Commands.SignUpUser;

public readonly struct SignUpUserResponseDto
{
    public required string Token { get; init; }
}