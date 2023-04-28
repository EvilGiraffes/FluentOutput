using FluentOutput.Formats;
using FluentOutput.Output;
using FluentOutput.ResultFormatters;

namespace FluentOutput;
/// <summary>
/// The options which the <see cref="ResultAttachment"/> uses for all its extention defaults.
/// </summary>
public sealed class ResultAttachmentOptions
{
    /// <summary>
    /// Which factory for <see cref="IResultOutput"/> <see cref="ResultAttachment"/> should use.
    /// </summary>
    public IResultOutputFactory OutputFactory { get; set; } = DefaultOutputFactory;
    /// <summary>
    /// Which result formatter <see cref="ResultAttachment"/> should use.
    /// </summary>
    public IResultFormatter ResultFormatter { get; set; } = DefaultResultFormatter;
    static IResultOutputFactory DefaultOutputFactory
        => new FormattingOutputFactory();
    static IResultFormatter DefaultResultFormatter
        => new NewLineSeperatedFormatter(
            new ColonFormat());
}
