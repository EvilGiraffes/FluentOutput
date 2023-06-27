using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.Transforms;
sealed class TypeSimpleNameTransform : ITransform<Type?>
{
    readonly string NoType;
    public TypeSimpleNameTransform(string noTypeRepresentation)
    {
        NoType = noTypeRepresentation;
    }
    public string Transform(Type? input)
        => input is null
        ? NoType
        : input.GetType().Name;
}
