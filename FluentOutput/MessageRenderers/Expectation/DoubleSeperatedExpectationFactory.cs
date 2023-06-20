namespace FluentOutput.MessageRenderers.Expectation;
/// <summary>
/// Represents a factory for <see cref="DoubleSeperatedExpectationRenderer"/>.
/// </summary>
public class DoubleSeperatedExpectationFactory : IExpectationRendererFactory
{
    readonly char valueSeperator;
    readonly string lineSeperator;
    /// <summary>
    /// Constructs a new instance of <see cref="DoubleSeperatedExpectationFactory"/>.
    /// </summary>
    /// <param name="valueSeperator"><inheritdoc cref="DoubleSeperatedExpectationBuilder.ValueSeperator(char)" path="/param[@name='valueSeperator']"/></param>
    /// <param name="lineSeperator"><inheritdoc cref="DoubleSeperatedExpectationBuilder.LineSeperator(string)" path="/param[@name='lineSeperator']"/></param>
    public DoubleSeperatedExpectationFactory(
        char valueSeperator = DoubleSeperatedExpectationBuilder.DefaultValueSeperator,
        string? lineSeperator = null)
    {
        this.valueSeperator = valueSeperator;
        this.lineSeperator = lineSeperator ?? DoubleSeperatedExpectationBuilder.DefaultLineSeperator;
    }
    /// <inheritdoc/>
    public IMessageRenderer Create(string actual, string expected)
        => DoubleSeperatedExpectationRenderer.Builder
        .Actual(actual)
        .Expected(expected)
        .ValueSeperator(valueSeperator)
        .LineSeperator(lineSeperator)
        .Build();
}
