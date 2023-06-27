namespace FluentOutput.Sdk.Abstractions;
/// <summary>
/// Represents a strategy to transform <typeparamref name="T"/> to <see cref="string"/>.
/// </summary>
/// <typeparam name="T">The type which it should transform from.</typeparam>
public interface ITransform<T>
{
    /// <summary>
    /// Transforms the <paramref name="input"/> into a <see cref="string"/>.
    /// </summary>
    /// <param name="input">The object to transform.</param>
    /// <returns>A new <see cref="string"/> representing <paramref name="input"/>.</returns>
    string Transform(T input);
}
