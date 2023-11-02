namespace Contracts.Features.Users.Commands.CreateUser;

public readonly struct CreateUserRequestDto
{
    public required string Name { get; init; }
    
    public required string Surname { get; init; }

    public required string Password { get; init; }

    public required string PasswordRepeat { get; init; }
}