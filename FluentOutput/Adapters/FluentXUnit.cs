using FluentOutput.MessageRenderers;

using Xunit.Abstractions;

namespace FluentOutput.Adapters;
/// <summary>
/// An adapter from <see cref="ITestOutputHelper"/> to <see cref="IFluentOutput"/>
/// </summary>
public sealed class FluentXUnit : IFluentOutput
{
    readonly ITestOutputHelper output;
    /// <summary>
    /// Constructs a new <see cref="FluentXUnit"/> adapter.
    /// </summary>
    /// <param name="output">The output to adapt.</param>
    public FluentXUnit(ITestOutputHelper output)
    {
        this.output = output;
    }
    /// <inheritdoc/>
    public void WriteLine(IMessageRenderer renderer)
        => output.WriteLine(renderer.Render());
}
