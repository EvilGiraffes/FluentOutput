using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.ApiOptions.Expectation;

namespace FluentOutput.Sdk;
/// <summary>
/// API for anything related to expectation objects.
/// </summary>
public static class Expectation
{
    /// <summary>
    /// Gets all the setting related to <see cref="IExpectationRenderHandler"/>.
    /// </summary>
    public static Handler Handler { get; } = new();
    /// <summary>
    /// Gets all the settings related to <see cref="IExpectationFormatter"/>.
    /// </summary>
    public static Formatter Formatter { get; } = new();
    /// <summary>
    /// Gets all the settings related to section writers.
    /// </summary>
    public static SectionWriter SectionWriter { get; } = new();
}