using FluentOutput.ResultFormatters;

using Xunit.Abstractions;

namespace FluentOutput.Output;
/// <summary>
/// Represents a factory to create instances of <see cref="FormattingOutput"/>.
/// </summary>
public sealed class FormattingOutputFactory : IResultOutputFactory
{
    /// <inheritdoc/>
    public IResultOutput Create(ITestOutputHelper output, IResultFormatter formatter)
        => new FormattingOutput(output, formatter);
}
