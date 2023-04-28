using FluentOutput.Formats;
using FluentOutput.Output;

namespace FluentOutput.ResultFormatters;
/// <summary>
/// Represents a <see cref="IResultOutput"/> which formats the output using a newline.
/// </summary>
public sealed class NewLineSeperatedFormatter : IResultFormatter
{
    readonly ISeperatedFormat seperatedFormat;
    static string NewLine
        => Environment.NewLine;
    /// <summary>
    /// Constructs a new instance of <see cref="NewLineSeperatedFormatter"/>.
    /// </summary>
    /// <param name="seperatedFormat">The formatting implementation detail.</param>
    public NewLineSeperatedFormatter(ISeperatedFormat seperatedFormat)
    {
        this.seperatedFormat = seperatedFormat;
    }
    /// <inheritdoc/>
    public string Format<T>(T expected, T actual)
        where T : notnull
        => seperatedFormat.Build(expected, actual, NewLine);
}
