using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.Transforms;
/// <summary>
/// Represents an <see cref="ITransform{T}"/> which will output a <see cref="string"/> representing the value, and a string representing <see langword="null"/> or empty if there is no value.
/// </summary>
/// <typeparam name="T"><inheritdoc cref="ITransform{T}" path="/typeparam"/></typeparam>
public sealed class NoValueHandlingTransform<T> : ITransform<T>
{
    const string Empty = "Empty";
    const string Null = "Null";
    /// <inheritdoc/>
    public string Transform(T input)
    {
        string? result = input?.ToString();
        if (result is null)
            return Null;
        if (result.Length <= 0)
            return Empty;
        return result;
    }
}
