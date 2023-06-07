using FluentOutput.Contexts;

namespace FluentOutput;
/// <summary>
/// Uses <see cref="ExpectationContext{T}"/> to write to the output for values related to any object where it is a class.
/// </summary>
/// <typeparam name="TContext">The current type of object used.</typeparam>
/// <typeparam name="TWriter">The type of writer being used.</typeparam>
public abstract class ReferenceTypeExpectationWriter<TContext, TWriter>
    where TWriter : ReferenceTypeExpectationWriter<TContext, TWriter>
{
    /// <summary>
    /// The current context being utilized.
    /// </summary>
    protected ExpectationContext<TContext> Context { get; }
    const string Null = "Null";
    const string NotNull = "Not " + Null;
    /// <summary>
    /// Creates a new instance of a <see cref="ReferenceTypeExpectationWriter{TContext, TWriter}"/>.
    /// </summary>
    /// <param name="context">The context which this expectation is built on.</param>
    protected ReferenceTypeExpectationWriter(ExpectationContext<TContext> context)
    {
        Context = context;
    }
    /// <summary>
    /// Expects the actual value to be <paramref name="expected"/>.
    /// </summary>
    /// <param name="expected">The value it expects it to be.</param>
    /// <returns>An <see cref="AndContext{T}"/> of type <typeparamref name="TWriter"/> for further processing.</returns>
    public AndContext<TWriter> ToBe(TContext expected)
    {
        Context.Render(expected);
        return (TWriter) this;
    }
    /// <summary>
    /// Expects the value to be <see langword="null"/>.
    /// </summary>
    /// <returns><inheritdoc cref="ToBe(TContext)" path="/returns"/></returns>
    public AndContext<TWriter> ToBeNull()
    {
        ExpectationContext<string> nullContext = Context.Map(NullTransform);
        nullContext.Render(Null);
        return (TWriter) this;
    }
    /// <summary>
    /// Expects the value to be not <see langword="null"/>.
    /// </summary>
    /// <returns><inheritdoc cref="ToBe(TContext)" path="/returns"/></returns>
    public AndContext<TWriter> ToNotBeNull()
    {
        ExpectationContext<string> nullContext = Context.Map(NullTransform);
        nullContext.Render(NotNull);
        return (TWriter) this;
    }
    /// <summary>
    /// Expects the value to be of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type its expected to be.</typeparam>
    /// <returns><inheritdoc cref="ToBe(TContext)" path="/returns"/></returns>
    public AndContext<TWriter> ToBeOfType<T>()
    {
        ExpectationContext<Type?> typeContext = Context.Map(value => value?.GetType());
        typeContext.Render(typeof(T));
        return (TWriter) this;
    }
    /// <summary>
    /// Expects the value to not be of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type it is not expected to be.</typeparam>
    /// <returns><inheritdoc cref="ToBe(TContext)" path="/returns"/></returns>
    public AndContext<TWriter> ToNotBeOfType<T>()
    {
        ExpectationContext<string> typeContext = Context.Map(value => TypeTransform(value?.GetType()));
        string expected = $"Not {TypeTransform(typeof(T))}";
        return (TWriter) this;
    }
    string NullTransform(TContext obj)
        => obj is null
        ? Null
        : NotNull;
    string TypeTransform(Type? type)
        => type?.Name ?? Null;
}
