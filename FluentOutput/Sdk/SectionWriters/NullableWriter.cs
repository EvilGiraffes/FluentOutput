using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;
using FluentOutput.Transforms;

namespace FluentOutput.Sdk.SectionWriters;
/// <summary>
/// Represents a writer which only handles the nullability aspect of it.
/// </summary>
/// <typeparam name="TContext">The context to which to check nullability of.</typeparam>
public sealed class NullableWriter<TContext> : INullabilityWriter
{
    readonly TContext actual;
    readonly IExpectationRenderHandler renderer;
    const string Null = "Null";
    const string NotNull = "Not " + Null;
    static readonly ITransform<TContext?> NullTransform = new NullTransform<TContext?>(Null, NotNull);
    /// <summary>
    /// Construct a new <see cref="NullableWriter{TContext}"/>.
    /// </summary>
    /// <param name="actual">The actual value.</param>
    /// <param name="renderer">The renderer to render output with.</param>
    public NullableWriter(TContext actual, IExpectationRenderHandler renderer)
    {
        this.actual = actual;
        this.renderer = renderer;
    }
    /// <inheritdoc/>
    public void ToBeNull()
        => renderer.Render(actual, default, NullTransform);
    /// <inheritdoc/>
    public void ToNotBeNull()
    {
        string transformedActual = NullTransform.Transform(actual);
        renderer.Render(transformedActual, NotNull);
    }
}
