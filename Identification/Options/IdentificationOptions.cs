namespace Identification.Options;

public sealed class IdentificationOptions
{
    public required string Secret { get; init; }
    public required TimeSpan TokenLifetime { get; init; }
}