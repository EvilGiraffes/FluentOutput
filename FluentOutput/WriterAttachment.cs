using FluentOutput.Output;

using Xunit.Abstractions;

namespace FluentOutput;
/// <summary>
/// Attaches a writer to the output.
/// </summary>
public static class WriterAttachment
{
    /// <summary>
    /// Will get an output provider based on <see cref="ITestOutputHelper"/>.
    /// </summary>
    /// <param name="output">The output to provide.</param>
    /// <returns>A new <see cref="IOutputProvider"/>.</returns>
    public static IOutputProvider Write(this ITestOutputHelper output)
        => new XUnitTestOutputProvider(output);
}
