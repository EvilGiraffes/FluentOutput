namespace FluentOutput.MessageRenderers;
/// <summary>
/// Represents an implementation of <see cref="IMessageRenderer"/> where the message is used as just a string.
/// </summary>
public sealed class StringRenderer : IMessageRenderer
{
    readonly string message;
    /// <summary>
    /// Constructs a new instance of <see cref="StringRenderer"/>.
    /// </summary>
    /// <param name="message">The message to render.</param>
    public StringRenderer(string message)
    {
        this.message = message;
    }
    /// <summary>
    /// <inheritdoc cref="StringRenderer(string)" path="/summary"/>
    /// </summary>
    /// <param name="format">The format for the message.</param>
    /// <param name="args">The arguments to the format.</param>
    /// <exception cref="FormatException">Thrown when the format or arguments is not valid.</exception>
    public StringRenderer(string format, params object[] args)
        : this(string.Format(format, args))
    {
    }
    /// <inheritdoc/>
    public string Render()
        => message;
}
