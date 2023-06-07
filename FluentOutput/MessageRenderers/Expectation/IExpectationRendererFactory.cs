using FluentOutput.Contexts;

namespace FluentOutput.MessageRenderers.Expectation;
// TODO: Convert to this.
/// <summary>
/// Represents a factory to create a renderer for a <see cref="ExpectationContext{T}"/>.
/// </summary>
public interface IExpectationRendererFactory
{
    /// <summary>
    /// Constructs a new instance of a <see cref="IMessageRenderer"/>.
    /// </summary>
    /// <param name="actual">The actual value.</param>
    /// <param name="expected">The expecting value.</param>
    /// <returns>A new instance of <see cref="IMessageRenderer"/> which formats with the given <paramref name="actual"/> and <paramref name="expected"/>.</returns>
    public IMessageRenderer Create(string actual, string expected);
}
