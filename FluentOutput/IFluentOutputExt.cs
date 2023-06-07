using FluentOutput.MessageRenderers;

namespace FluentOutput;
/// <summary>
/// Extentions for <see cref="IFluentOutput"/>.
/// </summary>
public static class IFluentOutputExt
{
    /// <summary>
    /// Writes a message to the <paramref name="output"/>.
    /// </summary>
    /// <param name="output">The output to write to.</param>
    /// <param name="message">The message to write.</param>
    public static void WriteLine(this IFluentOutput output, string? message)
    {
        if (message is null)
            return;
        IMessageRenderer renderer = new StringRenderer(message);
        output.WriteLine(renderer);
    }
    /// <summary>
    /// <inheritdoc cref="WriteLine(IFluentOutput, string?)" path="/summary"/>
    /// </summary>
    /// <param name="output"><inheritdoc cref="WriteLine(IFluentOutput, string?)" path="param[@name='output']"/></param>
    /// <param name="format">The format to use.</param>
    /// <param name="args">The arguments to the format.</param>
    public static void WriteLine(this IFluentOutput output, string? format, params object[] args)
    {
        if (format is null || args.Length < 1)
            return;
        IMessageRenderer renderer = new StringRenderer(format, args);
        output.WriteLine(renderer);
    }
}
