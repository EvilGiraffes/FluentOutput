using System.Text;

using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.MessageRenderers.Expectation;
/// <summary>
/// Represents an <see cref="IMessageRenderer"/> with an expectancy of an actual and expected value rendered nicely formatted inline.
/// </summary>
public sealed class InlineExpectationRenderer : IMessageRenderer
{
    readonly string actual;
    readonly string expected;
    readonly string seperator;
    readonly int cushion;
    const string ExpectedTitle = "Expected";
    const string ActualTitle = "Actual";
    const char Space = ' ';
    static readonly int longestFormat = Math.Max(ExpectedTitle.Length, ActualTitle.Length);
    /// <summary>
    /// Constructs a new <see cref="InlineExpectationRenderer"/>.
    /// </summary>
    /// <param name="actual">The actual value.</param>
    /// <param name="expected">The expected value.</param>
    /// <param name="seperator">The seperator to put between each value.</param>
    /// <param name="cushion">The cushion to use after the inlining. Can not be below 0.</param>
    /// <exception cref="ArgumentOutOfRangeException">Throw when the <paramref name="cushion"/> is out of range.</exception>
    public InlineExpectationRenderer(string actual, string expected, string seperator, int cushion = 1)
    {
        if (cushion < 0)
            throw new ArgumentOutOfRangeException(nameof(cushion), $"Cushion can not be below 0, was given {cushion}.");
        this.actual = actual;
        this.expected = expected;
        this.seperator = seperator;
        this.cushion = cushion;
    }
    /// <inheritdoc/>
    public string Render()
    {
        StringBuilder builder = new();
        AppendTitleValuePair(builder, ExpectedTitle, expected);
        builder.Append(Environment.NewLine);
        AppendTitleValuePair(builder, ActualTitle, actual);
        return builder.ToString();
    }
    void AppendTitleValuePair(StringBuilder builder, string title, string value)
    {
        builder.Append(title);
        CushionWord(builder, title.Length, longestFormat);
        CushionSeperator(builder);
        builder.Append(value);
    }
    void CushionWord(StringBuilder builder, int wordLength, int maxLength)
    {
        int calculatedCushion = maxLength - wordLength;
        builder.Append(Space, calculatedCushion);
    }
    void CushionSeperator(StringBuilder builder)
        => builder
        .Append(Space, cushion)
        .Append(seperator)
        .Append(Space, cushion);
}
