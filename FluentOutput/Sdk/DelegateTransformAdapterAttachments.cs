using FluentOutput.Sdk.Abstractions;
using FluentOutput.Transforms.Delegate;

namespace FluentOutput.Sdk;
/// <summary>
/// Adapts a <see langword="delegate"/> into an <see cref="ITransform{T}"/> where needed.
/// </summary>
public static class DelegateTransformAdapterAttachments
{
    /// <summary>
    /// <inheritdoc cref="IExpectationRenderHandler.Render{T}(T, T, ITransform{T}?)" path="/summary"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="renderer">The rendrer to use the transform on.</param>
    /// <param name="actual"><inheritdoc cref="IExpectationRenderHandler.Render{T}(T, T, ITransform{T}?)" path="/param[@name='actual']"/></param>
    /// <param name="expected"><inheritdoc cref="IExpectationRenderHandler.Render{T}(T, T, ITransform{T}?)" path="/param[@name='expected']"/></param>
    /// <param name="transform"><inheritdoc cref="IExpectationRenderHandler.Render{T}(T, T, ITransform{T}?)" path="/param[@name='transform']"/></param>
    public static void Render<T>(this IExpectationRenderHandler renderer, T actual, T expected, Func<T, string> transform)
    {
        ITransform<T> adaptedTransform = new DelegateTransformAdapter<T>(transform);
        renderer.Render(actual, expected, adaptedTransform);
    }
}
