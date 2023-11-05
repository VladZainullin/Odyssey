using Contracts.Features.Users.Commands.SignUpUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("users")]
[AllowAnonymous]
public sealed class UserController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<SignUpUserResponseDto>> SignUpUserAsync(
        SignUpUserRequestDto dto,
        CancellationToken cancellationToken)
    {
        return Ok(await Mediator.Send(new SignUpUserCommand(dto), cancellationToken));
    }
}