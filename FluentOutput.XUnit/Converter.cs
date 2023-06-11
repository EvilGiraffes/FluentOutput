using Xunit.Abstractions;

namespace FluentOutput.XUnit;
/// <summary>
/// Converts <see cref="ITestOutputHelper"/> to <see cref="IFluentOutput"/>.
/// </summary>
public static class Converter
{
    /// <summary>
    /// Adapts <see cref="ITestOutputHelper"/> to <see cref="IFluentOutput"/>.
    /// </summary>
    /// <param name="output">The instance of the output to adapt.</param>
    /// <returns>A new <see cref="FluentXUnit"/>.</returns>
    public static IFluentOutput ToFluent(this ITestOutputHelper output)
        => new FluentXUnit(output);
}
