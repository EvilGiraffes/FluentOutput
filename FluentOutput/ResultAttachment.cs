using FluentOutput.Output;
using FluentOutput.ResultFormatters;

using Xunit.Abstractions;

namespace FluentOutput;
/// <summary>
/// Represents all attachments of the <see cref="IResultOutput"/> writers to <see cref="ITestOutputHelper"/>.
/// </summary>
public static class ResultAttachment
{
    readonly static ResultAttachmentOptions Options = new();
    /// <summary>
    /// Will setup the <see cref="ResultAttachment"/> extention functions with new default values.
    /// </summary>
    /// <param name="setup">Where you will setup given the <see cref="ResultAttachmentOptions"/>.</param>
    public static void Setup(Action<ResultAttachmentOptions> setup)
        => setup(Options);
    /// <summary>
    /// Creates a new writer using the defaul <see cref="IResultFormatter"/> if <paramref name="formatter"/> is <see langword="null"/>, or using the <paramref name="formatter"/> if it has a value.
    /// </summary>
    /// <param name="output">The output it should wrap.</param>
    /// <param name="formatter">The optional formatter for this output.</param>
    /// <returns>A new <see cref="IResultOutput"/>.</returns>
    public static IResultOutput Write(this ITestOutputHelper output, IResultFormatter? formatter = null)
    {
        formatter ??= Options.ResultFormatter;
        return Options.OutputFactory.Create(output, formatter);
    }
}
