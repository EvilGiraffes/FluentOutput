namespace FluentOutput.MessageRenderers.Expectation;
/// <summary>
/// Represents a <see cref="IExpectationRendererFactory"/> which creates an <see cref="InlineExpectationRenderer"/>.
/// </summary>
public sealed class InlineExpectationRendererFactory : IExpectationRendererFactory
{
    readonly string seperator;
    readonly int cushion;
    /// <summary>
    /// Constructs a new <see cref="InlineExpectationRendererFactory"/>.
    /// </summary>
    /// <param name="seperator"><inheritdoc cref="InlineExpectationRenderer(string, string, string, int)" path="/param[@name='seperator']"/></param>
    /// <param name="cushion"><inheritdoc cref="InlineExpectationRenderer(string, string, string, int)" path="/param[@name='cushion']"/></param>
    public InlineExpectationRendererFactory(string seperator, int cushion = 1)
    {
        this.seperator = seperator;
        this.cushion = cushion;
    }
    /// <inheritdoc/>
    public IMessageRenderer Create(string actual, string expected)
        => new InlineExpectationRenderer(actual, expected, seperator, cushion);
}
