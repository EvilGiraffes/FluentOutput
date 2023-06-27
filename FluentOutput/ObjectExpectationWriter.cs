using FluentOutput.Contexts;
using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;

namespace FluentOutput;
/// <summary>
/// Writes output for <see cref="object"/> where an actual value is provided.
/// </summary>
public sealed class ObjectExpectationWriter
{
    readonly object? actual;
    readonly IExpectationRenderHandler renderer;
    readonly INullabilityWriter nullabilityWriter;
    readonly ITypeWriter typeWriter;
    internal ObjectExpectationWriter(object? actual, IExpectationRenderHandler renderer, INullabilityWriter nullabilityWriter, ITypeWriter typeWriter)
    {
        this.actual = actual;
        this.renderer = renderer;
        this.nullabilityWriter = nullabilityWriter;
        this.typeWriter = typeWriter;
    }
    /// <summary>
    /// Writes output expecting the equality of the actual and <paramref name="expected"/> value.
    /// </summary>
    /// <param name="expected">The value which is expected to be equal to the actual value.</param>
    /// <returns><see langword="this"/> for further processing.</returns>
    public AndContext<ObjectExpectationWriter> ToBe(object? expected)
    {
        renderer.Render(actual, expected);
        return this;
    }
    /// <summary>
    /// <inheritdoc cref="INullabilityWriter.ToBeNull" path="/summary"/>
    /// </summary>
    /// <returns><inheritdoc cref="ToBe(object?)" path="/returns"/></returns>
    public AndContext<ObjectExpectationWriter> ToBeNull()
    {
        nullabilityWriter.ToBeNull();
        return this;
    }
    /// <summary>
    /// <inheritdoc cref="INullabilityWriter.ToNotBeNull" path="/summary"/>
    /// </summary>
    /// <returns><inheritdoc cref="ToBe(object?)" path="/returns"/></returns>
    public AndContext<ObjectExpectationWriter> ToNotBeNull()
    {
        nullabilityWriter.ToNotBeNull();
        return this;
    }
    /// <summary>
    /// <inheritdoc cref="ITypeWriter.ToBeOfType{TExpected}" path="/summary"/>
    /// </summary>
    /// <typeparam name="TExpected"><inheritdoc cref="ITypeWriter.ToBeOfType{TExpected}" path="/typeparam"/></typeparam>
    /// <returns><inheritdoc cref="ToBe(object?)" path="/returns"/></returns>
    public AndContext<ObjectExpectationWriter> ToBeOfType<TExpected>()
    {
        typeWriter.ToBeOfType<TExpected>();
        return this;
    }
    /// <summary>
    /// <inheritdoc cref="ITypeWriter.ToNotBeOfType{TNotExpected}" path="/summary"/>
    /// </summary>
    /// <typeparam name="TNotExpected"><inheritdoc cref="ITypeWriter.ToNotBeOfType{TNotExpected}" path="/typeparam"/></typeparam>
    /// <returns><inheritdoc cref="ToBe(object?)" path="/returns"/></returns>
    public AndContext<ObjectExpectationWriter> ToNotBeOfType<TNotExpected>()
    {
        typeWriter.ToNotBeOfType<TNotExpected>();
        return this;
    }
    /// <summary>
    /// <inheritdoc cref="ITypeWriter.ToBeAssignableFrom{TExpected}" path="/summary"/>
    /// </summary>
    /// <typeparam name="TExpected"><inheritdoc cref="ITypeWriter.ToBeAssignableFrom{TExpected}" path="/typeparam"/></typeparam>
    /// <returns><inheritdoc cref="ToBe(object?)" path="/returns"/></returns>
    public AndContext<ObjectExpectationWriter> ToBeAssignableFrom<TExpected>()
    {
        typeWriter.ToBeAssignableFrom<TExpected>();
        return this;
    }
    /// <summary>
    /// <inheritdoc cref="ITypeWriter.ToNotBeAssignableFrom{TNotExpected}" path="/summary"/>
    /// </summary>
    /// <typeparam name="TNotExpected"><inheritdoc cref="ITypeWriter.ToNotBeAssignableFrom{TNotExpected}" path="/typeparam"/></typeparam>
    /// <returns><inheritdoc cref="ToBe(object?)" path="/returns"/></returns>
    public AndContext<ObjectExpectationWriter> ToNotBeAssignableFrom<TNotExpected>()
    {
        typeWriter.ToNotBeAssignableFrom<TNotExpected>();
        return this;
    }
}
