using FluentOutput.Contexts;
using FluentOutput.MessageRenderers.Expectation;

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
/// <summary>
/// Attaches the <see cref="ObjectExpectationWriter"/> as an expectation context.
/// </summary>
public static class ObjectExpectationWriterAttachment
{
    /// <summary>
    /// Expectation context on <paramref name="actual"/> for further processing.
    /// </summary>
    /// <param name="output"><inheritdoc cref="ExpectationContext{T}" path="/param[@name='output']"/></param>
    /// <param name="actual"><inheritdoc cref="ExpectationContext{T}" path="/param[@name='actual']"/></param>
    /// <param name="rendererFactory"><inheritdoc cref="ExpectationContext{T}" path="/param[@name='rendererFactory']"/></param>
    /// <returns>A new <see cref="ObjectExpectationWriter"/> for further processing.</returns>
    public static ObjectExpectationWriter Expecting(this IFluentOutput output, object? actual, IExpectationRendererFactory? rendererFactory = null)
        => new(
            new ExpectationContext<object?>(output, actual, rendererFactory));
}