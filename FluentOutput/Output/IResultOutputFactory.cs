using FluentOutput.ResultFormatters;

using Xunit.Abstractions;

namespace FluentOutput.Output;
/// <summary>
/// Represents a factory to create an instance of <see cref="IResultOutput"/>.
/// </summary>
public interface IResultOutputFactory
{
    /// <summary>
    /// Creates the new instance of <see cref="IResultOutput"/>.
    /// </summary>
    /// <param name="output">An output helper used to write to test output.</param>
    /// <param name="formatter">The formatter to format the output.</param>
    /// <returns>A new instance of <see cref="IResultOutput"/>.</returns>
    IResultOutput Create(ITestOutputHelper output, IResultFormatter formatter);
}
