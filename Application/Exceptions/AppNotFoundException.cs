namespace Application.Exceptions;

public sealed class AppNotFoundException : AppException
{
    public AppNotFoundException(string message) : base(message)
    {
    }

    public override int StatusCode => 404;
}