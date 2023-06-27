using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.MessageRenderers.Expectation;
/// <summary>
/// Represents a <see cref="IExpectationFormatter"/> which creates an <see cref="InlineExpectationRenderer"/>.
/// </summary>
public sealed class InlineExpectationFormatter : IExpectationFormatter
{
    readonly string seperator;
    readonly int cushion;
    /// <summary>
    /// Constructs a new <see cref="InlineExpectationFormatter"/>.
    /// </summary>
    /// <param name="seperator"><inheritdoc cref="InlineExpectationRenderer(string, string, string, int)" path="/param[@name='seperator']"/></param>
    /// <param name="cushion"><inheritdoc cref="InlineExpectationRenderer(string, string, string, int)" path="/param[@name='cushion']"/></param>
    public InlineExpectationFormatter(string seperator, int cushion = 1)
    {
        this.seperator = seperator;
        this.cushion = cushion;
    }
    /// <inheritdoc/>
    public IMessageRenderer Build(string actual, string expected)
        => new InlineExpectationRenderer(actual, expected, seperator, cushion);
}
