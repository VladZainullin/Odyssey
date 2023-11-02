namespace Contracts.Features.Users.Commands.CreateUser;

public readonly struct CreateUserResponseDto
{
    public required string Token { get; init; }
}