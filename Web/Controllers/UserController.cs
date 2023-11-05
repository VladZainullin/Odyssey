using Contracts.Features.Users.Commands.SignUpUser;
using Contracts.Features.Users.Queries.SignInUserToken;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("users")]
[AllowAnonymous]
public sealed class UserController : BaseController
{
    [HttpPost("sign-up")]
    public async Task<ActionResult<SignUpUserResponseDto>> SignUpUserAsync(
        SignUpUserRequestDto dto,
        CancellationToken cancellationToken)
    {
        return Ok(await Mediator.Send(new SignUpUserCommand(dto), cancellationToken));
    }

    [HttpPost("sign-in")]
    public async Task<ActionResult<SignInUserTokenResponseDto>> SignInUserAsync(
        SignInUserTokenRequestDto dto,
        CancellationToken cancellationToken)
    {
        return Ok(await Mediator.Send(new SignInUserTokenRequest(dto), cancellationToken));
    }
}