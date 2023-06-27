using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.MessageRenderers.String;
sealed class StringRenderer : IMessageRenderer
{
    readonly string message;
    public StringRenderer(string message)
    {
        this.message = message;
    }
    /// <inheritdoc/>
    public string Render()
        => message;
}
