using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;
using FluentOutput.Transforms;

namespace FluentOutput.Sdk.SectionWriters;
/// <summary>
/// Represents a writer which only handles the type aspect of it.
/// </summary>
/// <typeparam name="TContext">The context to handle type of.</typeparam>
public sealed class TypeWriter<TContext> : ITypeWriter
{
    readonly Type? actual;
    readonly IExpectationRenderHandler renderer;
    const string NoType = "No Type";
    const string Assignable = "Assignable";
    const string NotAssignable = "Not " + Assignable;
    static readonly ITransform<Type?> typeTransform = new TypeSimpleNameTransform(NoType);
    /// <summary>
    /// Constructs a new <see cref="TypeWriter{TContext}"/>.
    /// </summary>
    /// <param name="actual">The actual value.</param>
    /// <param name="renderer">The renderer to render output to.</param>
    public TypeWriter(TContext actual, IExpectationRenderHandler renderer)
    {
        this.actual = actual?.GetType();
        this.renderer = renderer;
    }
    /// <inheritdoc/>
    public void ToBeOfType<TExpected>()
        => renderer.Render(actual, typeof(TExpected), typeTransform);
    /// <inheritdoc/>
    public void ToNotBeOfType<TNotExpected>()
    {
        string actualType = typeTransform.Transform(actual);
        renderer.Render(actualType, NoType);
    }
    /// <inheritdoc/>
    public void ToBeAssignableFrom<TExpected>()
    {
        string actualAssignability = Assignability<TExpected>(actual);
        renderer.Render(actualAssignability, Assignable);
    }
    /// <inheritdoc/>
    public void ToNotBeAssignableFrom<TNotExpected>()
    {
        string actualAssignability = Assignability<TNotExpected>(actual);
        renderer.Render(actualAssignability, NotAssignable);
    }
    static bool IsAssignable<TExpected>(Type actual)
        => actual.IsAssignableFrom(typeof(TExpected));
    static string Assignability<TExpected>(Type? actual)
    {
        if (actual is null)
            return NotAssignable;
        if (!IsAssignable<TExpected>(actual))
            return NotAssignable;
        return Assignable;
    }
}
