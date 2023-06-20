using FluentOutput.Config;
using FluentOutput.Transforms;

namespace FluentOutput.Sdk;
/// <summary>
/// A helper class to provide <see cref="ITransform{T}"/> functionalities.
/// </summary>
public static class Transform
{
    /// <summary>
    /// Creates the default <see cref="ITransform{T}"/> as defined by the configurations.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="ITransform{T}" path="/typeparam"/></typeparam>
    /// <returns>A new instance of the default <see cref="ITransform{T}"/>.</returns>
    public static ITransform<T> Default<T>()
        => FluentOutputConfigurations
        .Options
        .DefaultTransformFactory
        .Create<T>();
}
