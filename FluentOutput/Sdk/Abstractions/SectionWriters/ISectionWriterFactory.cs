namespace FluentOutput.Sdk.Abstractions.SectionWriters;
/// <summary>
/// Creates a section writer defined as <typeparamref name="TWriter"/>.
/// </summary>
/// <typeparam name="TWriter">The type of section writer.</typeparam>
public interface ISectionWriterFactory<TWriter>
{
    /// <summary>
    /// Creates a new <typeparamref name="TWriter"/>.
    /// </summary>
    /// <typeparam name="TContext">The actual value given.</typeparam>
    /// <param name="actual">The actual value.</param>
    /// <param name="renderer">The renderer to render output.</param>
    /// <returns>A new instance of <typeparamref name="TWriter"/>.</returns>
    TWriter Create<TContext>(TContext actual, IExpectationRenderHandler renderer);
}
