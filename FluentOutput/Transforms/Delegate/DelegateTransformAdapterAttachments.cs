using FluentOutput.Contexts;

namespace FluentOutput.Transforms.Delegate;
/// <summary>
/// Adapts a <see langword="delegate"/> into an <see cref="ITransform{T}"/> where needed.
/// </summary>
public static class DelegateTransformAdapterAttachments
{
    /// <summary>
    /// <inheritdoc cref="IExpectationContext{T}.Render(T, ITransform{T}?)" path="/summary"/>
    /// </summary> 
    /// <typeparam name="T"><inheritdoc cref="IExpectationContext{T}" path="/typeparam[@name='T']"/></typeparam>
    /// <param name="context">The context to execute the render function on.</param>
    /// <param name="expected"><inheritdoc cref="IExpectationContext{T}.Render(T, ITransform{T}?)" path="/param[@name='expected']"/></param>
    /// <param name="transform"><inheritdoc cref="IExpectationContext{T}.Render(T, ITransform{T}?)" path="/param[@name='transform']"/></param>
    public static void Render<T>(this IExpectationContext<T> context, T expected, Func<T, string> transform)
    {
        ITransform<T> adaptedTransform = new DelegateTransformAdapter<T>(transform);
        context.Render(expected, adaptedTransform);
    }
}
