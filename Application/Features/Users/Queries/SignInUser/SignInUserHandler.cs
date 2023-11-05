using Application.Exceptions;
using Contracts.Features.Users.Queries.SignInUserToken;
using Contracts.Identification;
using Contracts.Persistence;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Users.Queries.SignInUser;

file sealed class SignInUserHandler : IRequestHandler<SignInUserTokenRequest, SignInUserTokenResponseDto>
{
    private readonly IAppDbContext _context;
    private readonly IJwtTokenService _jwtTokenService;

    public SignInUserHandler(IAppDbContext context, IJwtTokenService jwtTokenService)
    {
        _context = context;
        _jwtTokenService = jwtTokenService;
    }
    
    public async Task<SignInUserTokenResponseDto> Handle(SignInUserTokenRequest request, CancellationToken cancellationToken)
    {
        var user = await GetUserAsync(request.Dto.Username, cancellationToken);

        if (ReferenceEquals(user, default))
        {
            throw new AppNotFoundException("Пользователь с таким никнеймом ещё не зарегистрирован");
        }

        if (user.PasswordHash != request.Dto.Password)
        {
            throw new AppBadRequestException("Не верно указан пароль");
        }

        var jwtToken = _jwtTokenService.GetToken(user);

        return new SignInUserTokenResponseDto
        {
            Token = jwtToken
        };

    }

    private Task<User?> GetUserAsync(string username, CancellationToken cancellationToken)
    {
        return _context.Users
            .AsTracking()
            .Where(User.Spec.ByUsername(username))
            .SingleOrDefaultAsync(cancellationToken);
    }
}