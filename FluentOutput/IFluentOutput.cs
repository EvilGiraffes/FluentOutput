using FluentOutput.Sdk.Abstractions;

namespace FluentOutput;
/// <summary>
/// A provider for the test output.
/// </summary>
public interface IFluentOutput
{
    /// <summary>
    /// Writes to the output with the given <paramref name="renderer"/>.
    /// </summary>
    /// <param name="renderer">A strategy to render the message to output.</param>
    void WriteLine(IMessageRenderer renderer);
}
