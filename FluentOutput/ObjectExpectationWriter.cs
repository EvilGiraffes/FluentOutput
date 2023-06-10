using FluentOutput.Contexts;

namespace FluentOutput;
/// <summary>
/// Represents a writer where it uses <see cref="object"/> as the type.
/// </summary>
public sealed class ObjectExpectationWriter : ReferenceTypeExpectationWriter<object?, ObjectExpectationWriter>
{
    /// <summary>
    /// Constructs a new <see cref="ObjectExpectationWriter"/>.
    /// </summary>
    /// <param name="context"><inheritdoc 
    /// cref="ReferenceTypeExpectationWriter{TContext, TWriter}.ReferenceTypeExpectationWriter(ExpectationContext{TContext})" 
    /// path="/param[@name='context']"/></param>
    public ObjectExpectationWriter(ExpectationContext<object?> context) : base(context)
    {
    }
}
