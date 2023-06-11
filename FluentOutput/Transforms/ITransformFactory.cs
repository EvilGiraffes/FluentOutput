namespace FluentOutput.Transforms;
/// <summary>
/// Represents a factory to create a <see cref="ITransform{T}"/> of any type.
/// </summary>
public interface ITransformFactory
{
    /// <summary>
    /// Creates an <see cref="ITransform{T}"/> of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type to transform to <see cref="string"/>.</typeparam>
    /// <returns>A new <see cref="ITransform{T}"/>.</returns>
    ITransform<T> Create<T>();
}
