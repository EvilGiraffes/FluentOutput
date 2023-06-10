using FluentOutput.MessageRenderers.Expectation;

namespace FluentOutput.Contexts;
/// <summary>
/// Configurations for <see cref="ExpectationContext{T}"/>.
/// </summary>
public static class ExpectationContextConfig
{
    // TODO: Better way to handle configurations? 

    /// <summary>
    /// The factory to be used if none is provided.
    /// </summary>
    /// <value>Default value is a parameterless instance of <see cref="DoubleSeperatedExpectationFactory"/>.</value>
    public static IExpectationRendererFactory DefaultFactory { get; set; } = new DoubleSeperatedExpectationFactory();
}
