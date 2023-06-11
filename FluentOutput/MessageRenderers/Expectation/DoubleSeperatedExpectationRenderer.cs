namespace FluentOutput.MessageRenderers.Expectation;
/// <summary>
/// Represents a <see cref="IMessageRenderer"/> which creates an output based on an expectancy and an actual value.
/// </summary>
public sealed class DoubleSeperatedExpectationRenderer : IMessageRenderer
{
    /// <summary>
    /// Gets the builder to construct this object.
    /// </summary>
    public static DoubleSeperatedExpectationBuilder Builder
        => new();
    readonly string actual;
    readonly string expected;
    readonly char valueSeperator;
    readonly string lineSeperator;
    const string Format = "Expecting {0} {1}{2}Actual {0} {3}";
    internal DoubleSeperatedExpectationRenderer(string actual, string expected, char valueSeperator, string lineSeperator)
    {
        this.actual = actual;
        this.expected = expected;
        this.valueSeperator = valueSeperator;
        this.lineSeperator = lineSeperator;
    }
    /// <inheritdoc/>
    public string Render()
        => string.Format(Format, expected, valueSeperator, lineSeperator, actual);
}
