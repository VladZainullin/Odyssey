using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Contracts.Identification;
using Domain.Entities;
using Identification.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Identification;

public sealed class JwtTokenService : IJwtTokenService
{
    private readonly IOptionsSnapshot<IdentificationOptions> _identificationOptions;

    public JwtTokenService(IOptionsSnapshot<IdentificationOptions> identificationOptions)
    {
        _identificationOptions = identificationOptions;
    }
    
    public string GetToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_identificationOptions.Value.Secret);
        
        var claims = new Claim[]
        {
            new(JwtRegisteredClaimNames.Jti, user.Id.ToString()),
        };

        var tokenDescription = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTimeOffset.Now.Add(_identificationOptions.Value.TokenLifetime).DateTime,
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key), 
                SecurityAlgorithms.HmacSha256)
        };

        var token = tokenHandler.CreateToken(tokenDescription);

        return tokenHandler.WriteToken(token);
    }
}