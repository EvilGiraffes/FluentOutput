using FluentOutput.Contexts;
using FluentOutput.MessageRenderers;
using FluentOutput.MessageRenderers.Expectation;
using FluentOutput.Sdk;

namespace FluentOutput;
/// <summary>
/// A collection of extention methods to attach expectation related writing functionality to <see cref="IFluentOutput"/>.
/// </summary>
public static class ExpectationAttachment
{
    /// <summary>
    /// Builds the expectation for the message where the actual value is <paramref name="actual"/>.
    /// </summary>
    /// <typeparam name="T">The type being tested.</typeparam>
    /// <param name="output">The output to write to in the end of the line.</param>
    /// <param name="actual">The actual value.</param>
    /// <returns>An <see cref="IExpectationContext{T}"/> for further processing.</returns>
    public static IExpectationContext<T> Expecting<T>(this IFluentOutput output, T actual)
        => ExpectationContext.Create(output, actual);
    /// <summary>
    /// Attaches an <see cref="IExpectationRendererFactory"/> which creates a <see cref="IMessageRenderer"/> to control the formatting of the output.
    /// </summary>
    /// <param name="output"><inheritdoc cref="Expecting{T}(IFluentOutput, T)" path="/param[@name='output']"/></param>
    /// <param name="rendererfactory">The factory to control the rendering.</param> 
    /// <returns>A new <see cref="ExpectationRendererContext"/> for further processing.</returns>
    public static ExpectationRendererContext RenderWith(this IFluentOutput output, IExpectationRendererFactory rendererfactory)
        => new(output, rendererfactory);
}
