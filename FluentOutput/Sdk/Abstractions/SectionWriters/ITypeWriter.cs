namespace FluentOutput.Sdk.Abstractions.SectionWriters;
/// <summary>
/// Represents a writer which writes output where the expectancy is related to its <see cref="Type"/>.
/// </summary>
public interface ITypeWriter
{
    /// <summary>
    /// Writes the actual values type and <typeparamref name="TExpected"/> where it is expected to be of type <typeparamref name="TExpected"/>.
    /// </summary>
    /// <typeparam name="TExpected">The type which the actual value is expected to be.</typeparam>
    void ToBeOfType<TExpected>();
    /// <summary>
    /// Writes the actual values type and <typeparamref name="TNotExpected"/> where it is expected to not be of type <typeparamref name="TNotExpected"/>.
    /// </summary>
    /// <typeparam name="TNotExpected"></typeparam>
    void ToNotBeOfType<TNotExpected>();
    /// <summary>
    /// Writes the actual values assignability from <typeparamref name="TExpected"/> where it is expected to be assignable from <typeparamref name="TExpected"/>.
    /// </summary>
    /// <typeparam name="TExpected">The type it should be assignable from.</typeparam>
    void ToBeAssignableFrom<TExpected>();
    /// <summary>
    /// Writes the actual values assignability from <typeparamref name="TNotExpected"/> where it is not expected to be assignable from <typeparamref name="TNotExpected"/>.
    /// </summary>
    /// <typeparam name="TNotExpected">The type it should not be assignable from.</typeparam>
    void ToNotBeAssignableFrom<TNotExpected>();
}
