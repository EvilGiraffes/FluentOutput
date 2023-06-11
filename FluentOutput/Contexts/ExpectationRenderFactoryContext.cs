using FluentOutput.MessageRenderers;
using FluentOutput.MessageRenderers.Expectation;
using FluentOutput.Sdk;
using FluentOutput.Transforms;

namespace FluentOutput.Contexts;
/// <summary>
/// The context where there is an expectation between actual and expected value.
/// </summary>
/// <typeparam name="T">The type being tested.</typeparam>
public sealed class ExpectationRenderFactoryContext<T> : IExpectationContext<T>
{
    readonly IFluentOutput output;
    readonly T actual;
    readonly IExpectationRendererFactory rendererFactory;
    static IExpectationRendererFactory DefaultFactory
        => new DoubleSeperatedExpectationFactory();
    internal ExpectationRenderFactoryContext(IFluentOutput output, T actual, IExpectationRendererFactory? rendererFactory)
    {
        this.output = output;
        this.actual = actual;
        this.rendererFactory = rendererFactory ?? DefaultFactory;
    }
    /// <inheritdoc/>
    public void Render(T expected, ITransform<T>? transform = null)
    {
        transform ??= transform.OrDefault();
        string TransformedActual = transform.Transform(actual);
        string TransformedExpected = transform.Transform(expected);
        IMessageRenderer renderer = rendererFactory.Create(TransformedActual, TransformedExpected);
        output.WriteLine(renderer);
    }
    /// <inheritdoc/>
    public IExpectationContext<TReturn> Map<TReturn>(Func<T, TReturn> map)
        => new ExpectationRenderFactoryContext<TReturn>(output, map(actual), rendererFactory);
    string DefaultTransform(T value)
        => value?.ToString() ?? string.Empty;
}
