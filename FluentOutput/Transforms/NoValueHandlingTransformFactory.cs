using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.Transforms;
/// <summary>
/// Represents a factory to create <see cref="ITransform{T}"/>.
/// </summary>
public sealed class NoValueHandlingTransformFactory : ITransformFactory
{
    /// <inheritdoc/>
    public ITransform<T> Create<T>()
        => new NoValueHandlingTransform<T>();
}
