using FluentOutput.MessageRenderers.Expectation;
using FluentOutput.RenderHandlers;
using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;
using FluentOutput.Sdk.SectionWriters;

namespace FluentOutput.Config.Options;
/// <summary>
/// Configurations for expectation context line.
/// </summary>
public sealed class ExpectationOptions : IOption<ConfigurationOptions>
{
    /// <inheritdoc/>
    public ConfigurationOptions Return { get; }
    /// <summary>
    /// The <see cref="IExpectationFormatter"/> to use if none has been provided.
    /// </summary>
    /// <value>Default value is <see cref="DoubleSeperatedExpectationFormatter"/> with a parameterless constructor.</value>
    public IExpectationFormatter ExpectationFormatter { get; set; } = new DoubleSeperatedExpectationFormatter();
    /// <summary>
    /// The <see cref="IExpectationRenderHandlerFactory"/> to use if none has been provided.
    /// </summary>
    /// <value>Default value is <see cref="FormattedRenderHandlerFactory"/>.</value>
    public IExpectationRenderHandlerFactory ExpectationRenderHandlerFactory { get; set; } = new FormattedRenderHandlerFactory();
    /// <summary>
    /// The <see cref="INullabilityWriter"/> to create if none has been provided.
    /// </summary>
    public ISectionWriterFactory<INullabilityWriter> NullabilityWriterFactory { get; set; } = new NullableWriterFactory();
    /// <summary>
    /// The <see cref="ITypeWriter"/> to create if none has been provided.
    /// </summary>
    public ISectionWriterFactory<ITypeWriter> TypeWriterFactory { get; set; } = new TypeWriterFactory();
    internal ExpectationOptions(ConfigurationOptions parent)
    {
        Return = parent;
    }
}
