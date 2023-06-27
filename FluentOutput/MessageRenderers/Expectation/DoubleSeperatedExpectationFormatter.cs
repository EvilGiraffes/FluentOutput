using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.MessageRenderers.Expectation;
/// <summary>
/// Represents a factory for <see cref="DoubleSeperatedExpectationRenderer"/>.
/// </summary>
public class DoubleSeperatedExpectationFormatter : IExpectationFormatter
{
    readonly char valueSeperator;
    readonly string lineSeperator;
    /// <summary>
    /// Constructs a new instance of <see cref="DoubleSeperatedExpectationFormatter"/>.
    /// </summary>
    /// <param name="valueSeperator"><inheritdoc cref="DoubleSeperatedExpectationBuilder.ValueSeperator(char)" path="/param[@name='valueSeperator']"/></param>
    /// <param name="lineSeperator"><inheritdoc cref="DoubleSeperatedExpectationBuilder.LineSeperator(string)" path="/param[@name='lineSeperator']"/></param>
    public DoubleSeperatedExpectationFormatter(
        char valueSeperator = DoubleSeperatedExpectationBuilder.DefaultValueSeperator,
        string? lineSeperator = null)
    {
        this.valueSeperator = valueSeperator;
        this.lineSeperator = lineSeperator ?? DoubleSeperatedExpectationBuilder.DefaultLineSeperator;
    }
    /// <inheritdoc/>
    public IMessageRenderer Build(string actual, string expected)
        => DoubleSeperatedExpectationRenderer.Builder
        .Actual(actual)
        .Expected(expected)
        .ValueSeperator(valueSeperator)
        .LineSeperator(lineSeperator)
        .Build();
}
