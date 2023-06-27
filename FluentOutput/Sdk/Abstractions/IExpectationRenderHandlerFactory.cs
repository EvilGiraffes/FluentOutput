namespace FluentOutput.Sdk.Abstractions;
/// <summary>
/// Represents a factory to create an <see cref="IExpectationRenderHandler"/>.
/// </summary>
public interface IExpectationRenderHandlerFactory
{
    /// <summary>
    /// Creates a new <see cref="IExpectationRenderHandler"/>.
    /// </summary>
    /// <param name="output">The output to use in the render handler.</param>
    /// <returns>A new <see cref="IExpectationRenderHandler"/>.</returns>
    IExpectationRenderHandler Create(IFluentOutput output);
}
