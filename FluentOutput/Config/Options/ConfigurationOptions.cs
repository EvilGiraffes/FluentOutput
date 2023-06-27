using FluentOutput.Sdk.Abstractions;
using FluentOutput.Transforms;

namespace FluentOutput.Config.Options;
/// <summary>
/// The master configuration class containing all configurations.
/// </summary>
public sealed class ConfigurationOptions
{
    /// <summary>
    /// The options for the expectation line of output.
    /// </summary>
    public ExpectationOptions Expectation { get; }
    /// <summary>
    /// The option for a <see cref="ITransformFactory"/> where there is no <see cref="ITransform{T}"/> provided by default.
    /// </summary>
    /// <value>Default value is <see cref="NoValueHandlingTransformFactory"/>.</value>
    public ITransformFactory TransformFactory { get; set; } = new NoValueHandlingTransformFactory();

    internal ConfigurationOptions()
    {
        Expectation = new(this);
    }
}
