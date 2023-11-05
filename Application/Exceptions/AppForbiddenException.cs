namespace Application.Exceptions;

public sealed class AppForbiddenException : AppException
{
    public AppForbiddenException(string message) : base(message)
    {
    }

    public override int StatusCode => 403;
}