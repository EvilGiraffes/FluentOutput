using FluentOutput.Adapters;

using Xunit.Abstractions;

namespace FluentOutput;
/// <summary>
/// Collection of extention methods to adapt various test outputs to <see cref="IFluentOutput"/>.
/// </summary>
public static class FluentOutputConverter
{
    /// <summary>
    /// Adapts <see cref="ITestOutputHelper"/> to <see cref="IFluentOutput"/>.
    /// </summary>
    /// <param name="output">The instance of the output to adapt.</param>
    /// <returns>A new <see cref="FluentXUnit"/>.</returns>
    public static IFluentOutput ToFluent(this ITestOutputHelper output)
        => new FluentXUnit(output);
}
