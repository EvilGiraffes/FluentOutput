using Xunit.Abstractions;

namespace FluentOutput.Output;
/// <summary>
/// Provides the output for <see cref="ITestOutputHelper"/>.
/// </summary>
public sealed class XUnitTestOutputProvider : IOutputProvider
{
    readonly ITestOutputHelper output;
    /// <summary>
    /// Constructs a new instance of <see cref="XUnitTestOutputProvider"/>.
    /// </summary>
    /// <param name="output">The output to wrap.</param>
    public XUnitTestOutputProvider(ITestOutputHelper output)
    {
        this.output = output;
    }
    /// <inheritdoc/>
    public void WriteLine(string message)
        => throw new NotImplementedException();
}
