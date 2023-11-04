using Domain.Entities;

namespace Contracts.Identification;

public interface IIdentityService
{
    Task SignUpAsync(
        User user,
        string password,
        CancellationToken cancellationToken = default);

    Task SignInAsync(
        string username,
        string password,
        bool rememberMe = true,
        CancellationToken cancellationToken = default);

    Task SignOutAsync(CancellationToken cancellationToken = default);
}