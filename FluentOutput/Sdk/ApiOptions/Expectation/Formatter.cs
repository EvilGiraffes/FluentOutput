using System.Diagnostics.CodeAnalysis;

using FluentOutput.Config;
using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.Sdk.ApiOptions.Expectation;
/// <summary>
/// API for <see cref="IExpectationFormatter"/>.
/// </summary>
public sealed class Formatter
{
    /// <summary>
    /// The current <see cref="IExpectationFormatter"/> as defined by configurations.
    /// </summary>
    [SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Options can not be static.")]
    public IExpectationFormatter Current
        => FluentOutputConfigurations
        .Options
        .Expectation
        .ExpectationFormatter;
    internal Formatter()
    {
    }
}
