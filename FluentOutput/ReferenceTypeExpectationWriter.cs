using FluentOutput.Contexts;

namespace FluentOutput;
/// <summary>
/// Uses <see cref="IExpectationContext{T}"/> to write to the output for values related to any object where it is a class.
/// </summary>
/// <typeparam name="TContext">The current type of object used.</typeparam>
/// <typeparam name="TWriter">The type of writer being used.</typeparam>
public abstract class ReferenceTypeExpectationWriter<TContext, TWriter>
    where TWriter : ReferenceTypeExpectationWriter<TContext, TWriter>
{
    /// <summary>
    /// The current context being utilized.
    /// </summary>
    protected IExpectationContext<TContext> Context { get; }
    const string Null = "Null";
    const string NotNull = "Not " + Null;
    /// <summary>
    /// Creates a new instance of a <see cref="ReferenceTypeExpectationWriter{TContext, TWriter}"/>.
    /// </summary>
    /// <param name="context">The context which this expectation is built on.</param>
    protected ReferenceTypeExpectationWriter(IExpectationContext<TContext> context)
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
        IExpectationContext<string> nullContext = Context.Map(NullMap);
        nullContext.Render(Null);
        return (TWriter) this;
    }
    /// <summary>
    /// Expects the value to be not <see langword="null"/>.
    /// </summary>
    /// <returns><inheritdoc cref="ToBe(TContext)" path="/returns"/></returns>
    public AndContext<TWriter> ToNotBeNull()
    {
        IExpectationContext<string> nullContext = Context.Map(NullMap);
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
        IExpectationContext<Type?> typeContext = Context.Map(value => value?.GetType());
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
        IExpectationContext<string> typeContext = Context.Map(value => TypeMap(value?.GetType()));
        string expected = $"Not {TypeMap(typeof(T))}";
        return (TWriter) this;
    }
    string NullMap(TContext obj)
        => obj is null
        ? Null
        : NotNull;
    string TypeMap(Type? type)
        => type?.Name ?? Null;
}
