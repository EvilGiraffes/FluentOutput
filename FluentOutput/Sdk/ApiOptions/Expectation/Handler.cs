using System.Diagnostics.CodeAnalysis;

using FluentOutput.Config;
using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.Sdk.ApiOptions.Expectation;
/// <summary>
/// API for <see cref="IExpectationRenderHandler"/>.
/// </summary>
public sealed class Handler
{
    internal Handler()
    {
    }
    /// <summary>
    /// Creates a <see cref="IExpectationRenderHandler"/>.
    /// </summary>
    /// <param name="output">The output to use in the handler.</param>
    /// <returns>A new <see cref="IExpectationRenderHandler"/>.</returns>
    [SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Options can not be static.")]
    public IExpectationRenderHandler Create(IFluentOutput output)
        => FluentOutputConfigurations
        .Options
        .Expectation
        .ExpectationRenderHandlerFactory
        .Create(output);
}
