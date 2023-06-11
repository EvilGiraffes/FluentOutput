using FluentOutput.Contexts;
using FluentOutput.MessageRenderers.Expectation;

namespace FluentOutput.Sdk;
/// <summary>
/// Handles <see cref="IExpectationContext{T}"/> creation.
/// </summary>
public static class ExpectationContext
{
    /// <summary>
    /// Creates a new <see cref="IExpectationContext{T}"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="IExpectationContext{T}" path="/typeparam"/></typeparam>
    /// <param name="output"><inheritdoc cref="IExpectationContext{T}" path="/param[@name='output']"/></param>
    /// <param name="actual"><inheritdoc cref="IExpectationContext{T}" path="/param[@name='actual']"/></param>
    /// <param name="rendererFactory"><inheritdoc cref="IExpectationContext{T}" path="/param[@name='rendererFactory']"/></param>
    /// <returns></returns>
    public static IExpectationContext<T> Create<T>(IFluentOutput output, T actual, IExpectationRendererFactory? rendererFactory = null)
        => new ExpectationRenderFactoryContext<T>(output, actual, rendererFactory);
}