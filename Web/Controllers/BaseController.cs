using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
public sealed class BaseController : ControllerBase
{
    public IMediator Mediator => HttpContext.RequestServices.GetRequiredService<IMediator>();
}