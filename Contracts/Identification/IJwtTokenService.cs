using Domain.Entities;

namespace Contracts.Identification;

public interface IJwtTokenService
{
    string GetToken(User user);
}