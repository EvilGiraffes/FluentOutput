using FluentOutput.Contexts;

namespace FluentOutput;
/// <summary>
/// Represents a writer where it uses <see cref="object"/> as the type.
/// </summary>
public sealed class ObjectExpectationWriter : ReferenceTypeExpectationWriter<object?, ObjectExpectationWriter>
{
    internal ObjectExpectationWriter(IExpectationContext<object?> context) : base(context)
    {
    }
}
