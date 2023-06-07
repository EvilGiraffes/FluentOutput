using System.Diagnostics;

namespace FluentOutput.Contexts;
/// <summary>
/// Gives a context where you can continue writing to the output.
/// </summary>
/// <typeparam name="T">The current context.</typeparam>
[DebuggerStepThrough]
public sealed class AndContext<T>
{
    /// <summary>
    /// The context to continue writing to.
    /// </summary>
    public T And { get; }
    /// <summary>
    /// Constructs a new <see cref="AndContext{T}"/>.
    /// </summary>
    /// <param name="and"><inheritdoc cref="And" path="/summary"/></param>
    public AndContext(T and)
    {
        And = and;
    }
    /// <summary>
    /// Converts <typeparamref name="T"/> into an <see cref="AndContext{T}"/>.
    /// </summary>
    /// <param name="context">The <typeparamref name="T"/> instance to convert from.</param>
    public static implicit operator AndContext<T>(T context)
        => new(context);
}
