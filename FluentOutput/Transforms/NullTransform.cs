using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.Transforms;
class NullTransform<T> : ITransform<T>
{
    readonly string Null;
    readonly string NotNull;
    public NullTransform(string nullRepresentation, string notNullRepresentation)
    {
        Null = nullRepresentation;
        NotNull = notNullRepresentation;
    }
    public string Transform(T input)
        => input is null
        ? Null
        : NotNull;
}
