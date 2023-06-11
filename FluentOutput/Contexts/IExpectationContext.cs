using FluentOutput.Transforms;

namespace FluentOutput.Contexts;
/// <summary>
/// The context where there is an expectation between actual and expected value.
/// </summary>
/// <typeparam name="T">The type being tested.</typeparam>
public interface IExpectationContext<T>
{
    /// <summary>
    /// Writes the expectation to the output.
    /// </summary>
    /// <param name="expected">The expected value.</param>
    /// <param name="transform">The transform to use on this object.</param>
    void Render(T expected, ITransform<T>? transform = null);
    /// <summary>
    /// Maps the actual value from <typeparamref name="T"/> to <typeparamref name="TReturn"/> wrapped in a new context for further processing.
    /// </summary>
    /// <typeparam name="TReturn">The new type.</typeparam>
    /// <param name="map">The mapping function to transform the actual value.</param>
    /// <returns>A new <see cref="IExpectationContext{T}"/> of type <typeparamref name="TReturn"/>.</returns>
    IExpectationContext<TReturn> Map<TReturn>(Func<T, TReturn> map);
}
