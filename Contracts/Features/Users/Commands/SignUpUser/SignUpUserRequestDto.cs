namespace Contracts.Features.Users.Commands.SignUpUser;

public readonly struct SignUpUserRequestDto
{
    public required string Username { get; init; }

    public required string Password { get; init; }

    public required string PasswordRepeat { get; init; }
}