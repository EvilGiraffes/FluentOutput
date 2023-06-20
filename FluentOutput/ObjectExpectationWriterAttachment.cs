using FluentOutput.Contexts;
using FluentOutput.MessageRenderers.Expectation;
using FluentOutput.Sdk;

namespace FluentOutput;

/// <summary>
/// Attaches the <see cref="ObjectExpectationWriter"/> as an expectation context.
/// </summary>
public static class ObjectExpectationWriterAttachment
{
    /// <summary>
    /// Expectation context on <paramref name="actual"/> for further processing.
    /// </summary>
    /// <param name="output"><inheritdoc cref="RenderedContext{T}" path="/param[@name='output']"/></param>
    /// <param name="actual"><inheritdoc cref="RenderedContext{T}" path="/param[@name='actual']"/></param>
    /// <param name="rendererFactory"><inheritdoc cref="RenderedContext{T}" path="/param[@name='rendererFactory']"/></param>
    /// <returns>A new <see cref="ObjectExpectationWriter"/> for further processing.</returns>
    public static ObjectExpectationWriter Expecting(this IFluentOutput output, object? actual, IExpectationRendererFactory? rendererFactory = null)
        => new(
            ExpectationContext.Create(output, actual, rendererFactory));
}