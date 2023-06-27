using FluentOutput.Sdk;
using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.RenderHandlers;
/// <summary>
/// Represents a <see cref="IExpectationRenderHandlerFactory"/> to create <see cref="FormattedRenderHandler"/>.
/// </summary>
public sealed class FormattedRenderHandlerFactory : IExpectationRenderHandlerFactory
{
    /// <inheritdoc/>
    public IExpectationRenderHandler Create(IFluentOutput output)
        => new FormattedRenderHandler(output, Expectation.Formatter.Current);
}
