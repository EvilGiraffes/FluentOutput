namespace FluentOutput.Sdk.Abstractions;
/// <summary>
/// Renders a message for the <see cref="IFluentOutput"/>.
/// </summary>
public interface IMessageRenderer
{
    /// <summary>
    /// Renders the message.
    /// </summary>
    /// <returns>The message to output.</returns>
    string Render();
}
