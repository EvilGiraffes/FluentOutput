using FluentOutput.Sdk;
using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.RenderHandlers;
/// <summary>
/// Represents an <see cref="IExpectationRenderHandler"/> which uses a <see cref="IExpectationFormatter"/> to format output.
/// </summary>
public sealed class FormattedRenderHandler : IExpectationRenderHandler
{
    readonly IFluentOutput output;
    readonly IExpectationFormatter formatter;
    /// <summary>
    /// Constructs a new <see cref="FormattedRenderHandler"/>.
    /// </summary>
    /// <param name="output">The output to render to.</param>
    /// <param name="formatter">The formatter to use.</param>
    public FormattedRenderHandler(IFluentOutput output, IExpectationFormatter formatter)
    {
        this.output = output;
        this.formatter = formatter;
    }
    /// <inheritdoc/>
    public void Render<T>(T actual, T expected, ITransform<T>? transform = null)
    {
        transform ??= Transform.Current<T>();
        string transformedActual = transform.Transform(actual);
        string transformedExpected = transform.Transform(expected);
        IMessageRenderer renderer = formatter.Build(transformedActual, transformedExpected);
        output.WriteLine(renderer);
    }
}
