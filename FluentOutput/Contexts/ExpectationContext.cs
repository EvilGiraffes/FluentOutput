using FluentOutput.MessageRenderers;
using FluentOutput.MessageRenderers.Expectation;

namespace FluentOutput.Contexts;
/// <summary>
/// The context where there is an expectation between actual and expected value.
/// </summary>
/// <typeparam name="T">The type being tested.</typeparam>
public sealed class ExpectationContext<T>
{
    readonly IFluentOutput output;
    readonly T actual;
    readonly IExpectationRendererFactory rendererFactory;
    /// <summary>
    /// Constructs a new <see cref="ExpectationContext{T}"/>.
    /// </summary>
    /// <param name="output">The output to write to.</param>
    /// <param name="actual">The actual value.</param>
    /// <param name="rendererFactory">The renderer to use for output. <inheritdoc cref="ExpectationContextConfig.DefaultFactory" path="/value"/></param>
    public ExpectationContext(IFluentOutput output, T actual, IExpectationRendererFactory? rendererFactory = null)
    {
        this.output = output;
        this.actual = actual;
        this.rendererFactory = rendererFactory ?? ExpectationContextConfig.DefaultFactory;
    }
    /// <summary>
    /// Writes the expectation to the output.
    /// </summary>
    /// <param name="expected">The expected value.</param>
    /// <param name="transform">
    /// <para>The transform to use on this object.</para> 
    /// <para>By default it uses the <see cref="object.ToString()"/> method, or <see cref="string.Empty"/> if <see langword="null"/>.</para>
    /// </param>
    public void Render(T expected, Func<T, string>? transform = null)
    {
        transform ??= DefaultTransform;
        string TransformedActual = transform(actual);
        string TransformedExpected = transform(expected);
        IMessageRenderer renderer = rendererFactory.Create(TransformedActual, TransformedExpected);
        output.WriteLine(renderer);
    }
    /// <summary>
    /// Maps the actual value from <typeparamref name="T"/> to <typeparamref name="TReturn"/> wrapped in a new context for further processing.
    /// </summary>
    /// <typeparam name="TReturn">The new type.</typeparam>
    /// <param name="map">The mapping function to transform the actual value.</param>
    /// <returns>A new <see cref="ExpectationContext{TReturn}"/> of type <typeparamref name="TReturn"/>.</returns>
    public ExpectationContext<TReturn> Map<TReturn>(Func<T, TReturn> map)
        => new(output, map(actual), rendererFactory);
    string DefaultTransform(T value)
        => value?.ToString() ?? string.Empty;
}
