using FluentOutput.MessageRenderers.Expectation;

namespace FluentOutput.Config.Options;
/// <summary>
/// Configurations for expectation context line.
/// </summary>
public sealed class ExpectationOptions : IOption<ConfigurationOptions>
{
    /// <inheritdoc/>
    public ConfigurationOptions Return { get; }
    /// <summary>
    /// The <see cref="IExpectationRendererFactory"/> to use if none has been provided.
    /// </summary>
    /// <value>Default value is <see cref="DoubleSeperatedExpectationFactory"/> with a parameterless constructor.</value>
    public IExpectationRendererFactory DefaultExpectationRendererFactory { get; set; } = new DoubleSeperatedExpectationFactory();
    internal ExpectationOptions(ConfigurationOptions parent)
    {
        Return = parent;
    }
}
