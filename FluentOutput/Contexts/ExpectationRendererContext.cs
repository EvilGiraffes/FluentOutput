using FluentOutput.MessageRenderers.Expectation;

namespace FluentOutput.Contexts;
/// <summary>
/// Context where an <see cref="IExpectationRendererFactory"/> is provided.
/// </summary>
public sealed class ExpectationRendererContext
{
    readonly IFluentOutput output;
    readonly IExpectationRendererFactory rendererFactory;
    /// <summary>
    /// Constructs a new <see cref="ExpectationRendererContext"/>.
    /// </summary>
    /// <param name="output">The output to be further processed in <see cref="ExpectationContext{T}"/>.</param>
    /// <param name="rendererFactory">The factory to be used in the <see cref="ExpectationContext{T}"/>.</param>
    public ExpectationRendererContext(IFluentOutput output, IExpectationRendererFactory rendererFactory)
    {
        this.output = output;
        this.rendererFactory = rendererFactory;
    }
    /// <summary>
    /// <inheritdoc cref="ExpectationAttachment.Expecting{T}(IFluentOutput, T)" path="/summary"/>
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="ExpectationAttachment.Expecting{T}(IFluentOutput, T)" path="/typeparam"/></typeparam>
    /// <param name="actual"><inheritdoc cref="ExpectationAttachment.Expecting{T}(IFluentOutput, T)" path="/param[@name='actual']"/></param>
    /// <returns><inheritdoc cref="ExpectationAttachment.Expecting{T}(IFluentOutput, T)" path="/returns"/></returns>
    public ExpectationContext<T> Expecting<T>(T actual)
        => new(output, actual, rendererFactory);
}
