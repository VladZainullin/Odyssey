using Application.Exceptions;
using Contracts.Features.Users.Commands.SignUpUser;
using Contracts.Identification;
using Contracts.Persistence;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Users.SignUpUser;

file sealed class SignUpUserHandler : IRequestHandler<SignUpUserCommand, SignUpUserResponseDto>
{
    private readonly IAppDbContext _context;
    private readonly IJwtTokenService _jwtTokenService;

    public SignUpUserHandler(IAppDbContext context, IJwtTokenService jwtTokenService)
    {
        _context = context;
        _jwtTokenService = jwtTokenService;
    }
    
    public async Task<SignUpUserResponseDto> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
    {
        var exists = await IsExistsUsernameAsync(request, cancellationToken);
        if (exists)
        {
            throw new AppBadRequestException("Пользователь с таким никнеймом уже существует");
        }
        
        var user = new User(request.Dto.Username, request.Dto.Password);

        await _context.Users.AddAsync(user, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        var jwtToken = _jwtTokenService.GetToken(user);

        return new SignUpUserResponseDto
        {
            Token = jwtToken
        };
    }

    private Task<bool> IsExistsUsernameAsync(SignUpUserCommand request, CancellationToken cancellationToken)
    {
        return _context.Users
            .AsNoTracking()
            .Where(User.Spec.ByUsername(request.Dto.Username))
            .AnyAsync(cancellationToken);
    }
}