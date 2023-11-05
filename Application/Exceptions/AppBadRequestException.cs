namespace Application.Exceptions;

public sealed class AppBadRequestException : AppException
{
    public AppBadRequestException(string message) : base(message)
    {
    }

    public override int StatusCode => 400;
}