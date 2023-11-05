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
        var key = Encoding.UTF8.GetBytes(_identificationOptions.Value.Key);
        
        var claims = new Claim[]
        {
            new(JwtRegisteredClaimNames.Jti, user.Id.ToString()),
        };

        var tokenDescription = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTimeOffset.Now.AddMinutes(5).DateTime,
            Issuer = _identificationOptions.Value.Issuer,
            Audience = _identificationOptions.Value.Audience,
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key), 
                SecurityAlgorithms.Sha256)
        };

        var token = tokenHandler.CreateToken(tokenDescription);

        return tokenHandler.WriteToken(token);
    }
}