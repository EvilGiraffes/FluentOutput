using FluentOutput.Transforms;

namespace FluentOutput.Sdk;
/// <summary>
/// Extentions to handle the <see cref="ITransform{T}"/>.
/// </summary>
public static class ITransformExt
{
    /// <summary>
    /// Checks if the <paramref name="transform"/> is not null, if it is provides the default.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="ITransform{T}" path="/typeparam"/></typeparam>
    /// <param name="transform">The transform to ensure is not null.</param>
    /// <returns><paramref name="transform"/> if not <see langword="null"/>, the default <see cref="ITransform{T}"/> if <see langword="null"/>.</returns>
    public static ITransform<T> OrDefault<T>(this ITransform<T>? transform)
        => transform is null
        ? Transform.Default<T>()
        : transform;
}
