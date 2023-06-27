using FluentOutput.Config;
using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.Sdk;
/// <summary>
/// API for <see cref="ITransform{T}"/>.
/// </summary>
public static class Transform
{
    /// <summary>
    /// Creates the current <see cref="ITransform{T}"/> as defined by the configurations.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="ITransform{T}" path="/typeparam"/></typeparam>
    /// <returns>A new instance of <see cref="ITransform{T}"/> from the current <see cref="ITransformFactory"/>.</returns>
    public static ITransform<T> Current<T>()
        => FluentOutputConfigurations
        .Options
        .TransformFactory
        .Create<T>();
}
