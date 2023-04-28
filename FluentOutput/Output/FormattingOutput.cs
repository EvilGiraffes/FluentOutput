using FluentOutput.ResultFormatters;

using Xunit.Abstractions;

namespace FluentOutput.Output;
/// <summary>
/// Represents an <see cref="IResultOutput"/> which uses a <see cref="IResultFormatter"/> to format its output.
/// </summary>
public sealed class FormattingOutput : IResultOutput
{
    readonly ITestOutputHelper output;
    readonly IResultFormatter formatter;
    /// <summary>
    /// Constructs a new instance of <see cref="FormattingOutput"/>.
    /// </summary>
    /// <param name="output">The output helper to provide the output from the test.</param>
    /// <param name="formatter">The formatter used to write the output.</param>
    public FormattingOutput(ITestOutputHelper output, IResultFormatter formatter)
    {
        this.output = output;
        this.formatter = formatter;
    }
    /// <inheritdoc/>
    public void WriteResult<T>(T expected, T actual)
        where T : notnull
        => output.WriteLine(formatter.Format(expected, actual));
}