namespace Identification.Options;

public sealed class IdentificationOptions
{
    public required string Issuer { get; init; }

    public required string Audience { get; init; }

    public required string Key { get; init; }
}