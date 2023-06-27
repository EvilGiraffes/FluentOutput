using System.Diagnostics.CodeAnalysis;

using FluentOutput.Config;
using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;

namespace FluentOutput.Sdk.ApiOptions.Expectation;
/// <summary>
/// API for section writers.
/// </summary>
public sealed class SectionWriter
{
    const string StaticSuppressionJustification = "Options can not be static.";
    internal SectionWriter()
    {
    }
    /// <summary>
    /// Creates a new <see cref="INullabilityWriter"/>.
    /// </summary>
    /// <typeparam name="TContext"><inheritdoc cref="ISectionWriterFactory{TWriter}.Create{TContext}(TContext, IExpectationRenderHandler)" path="/typeparam"/></typeparam>
    /// <param name="actual">
    /// <inheritdoc 
    /// cref="ISectionWriterFactory{TWriter}.Create{TContext}(TContext, IExpectationRenderHandler)" 
    /// path="/param[@name='actual']"/>
    /// </param>
    /// <param name="renderer">
    /// <inheritdoc 
    /// cref="ISectionWriterFactory{TWriter}.Create{TContext}(TContext, IExpectationRenderHandler)" 
    /// path="/param[@name='renderer']"/>
    /// </param>
    /// <returns>A new <see cref="INullabilityWriter"/>.</returns>
    [SuppressMessage("Performance", "CA1822:Mark members as static", Justification = StaticSuppressionJustification)]
    public INullabilityWriter NullabilityWriter<TContext>(TContext actual, IExpectationRenderHandler renderer)
        => FluentOutputConfigurations
        .Options
        .Expectation
        .NullabilityWriterFactory
        .Create(actual, renderer);
    /// <summary>
    /// Creates a new <see cref="ITypeWriter"/>.
    /// </summary>
    /// <typeparam name="TContext"><inheritdoc cref="ISectionWriterFactory{TWriter}.Create{TContext}(TContext, IExpectationRenderHandler)" path="/typeparam"/></typeparam>
    /// <param name="actual">
    /// <inheritdoc 
    /// cref="ISectionWriterFactory{TWriter}.Create{TContext}(TContext, IExpectationRenderHandler)" 
    /// path="/param[@name='actual']"/>
    /// </param>
    /// <param name="renderer">
    /// <inheritdoc 
    /// cref="ISectionWriterFactory{TWriter}.Create{TContext}(TContext, IExpectationRenderHandler)" 
    /// path="/param[@name='renderer']"/>
    /// </param>
    /// <returns>A new <see cref="ITypeWriter"/>.</returns>
    [SuppressMessage("Performance", "CA1822:Mark members as static", Justification = StaticSuppressionJustification)]
    public ITypeWriter TypeWriter<TContext>(TContext actual, IExpectationRenderHandler renderer)
        => FluentOutputConfigurations
        .Options
        .Expectation
        .TypeWriterFactory
        .Create(actual, renderer);
}
