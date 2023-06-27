using FluentOutput.Sdk;
using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;

namespace FluentOutput;
/// <summary>
/// Attaches <see cref="ObjectExpectationWriter"/> as the expectation writer.
/// </summary>
public static class ObjectExpectationWriterAttachment
{
    /// <summary>
    /// Sets an expectation for an expected value in later processing.
    /// </summary>
    /// <param name="output">The output to render to.</param>
    /// <param name="actual">The actual value.</param>
    /// <returns>A new <see cref="ObjectExpectationWriter"/> for further processing.</returns>
    public static ObjectExpectationWriter Expecting(this IFluentOutput output, object? actual)
    {
        IExpectationRenderHandler renderer = Expectation.Handler.Create(output);
        INullabilityWriter nullabilityWriter = Expectation.SectionWriter.NullabilityWriter(actual, renderer);
        ITypeWriter typeWriter = Expectation.SectionWriter.TypeWriter(actual, renderer);
        return new ObjectExpectationWriterBuilder()
            .Actual(actual)
            .Renderer(renderer)
            .NullabilityWriter(nullabilityWriter)
            .TypeWriter(typeWriter)
            .Build();
    }
}
