namespace FluentOutput.Sdk.Abstractions;
/// <summary>
/// Represents a handler to render to the test output.
/// </summary>
public interface IExpectationRenderHandler
{
    /// <summary>
    /// Renders the message to the test output.
    /// </summary>
    /// <typeparam name="T">The type to render.</typeparam>
    /// <param name="actual">The actual value.</param>
    /// <param name="expected">The expected value.</param>
    /// <param name="transform">The transform to use on <paramref name="actual"/> and <paramref name="expected"/> to create string representation.</param>
    void Render<T>(T actual, T expected, ITransform<T>? transform = null);
}
