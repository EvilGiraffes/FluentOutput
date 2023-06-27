using FluentOutput.Errors;
using FluentOutput.Sdk.Abstractions;

namespace FluentOutput.MessageRenderers.String;
/// <summary>
/// Extentions for <see cref="IFluentOutput"/> to render using basic string operations.
/// </summary>
public static class StringRenderingExt
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
    /// <exception cref="InvalidOutputFormat">Thrown if the format or arguements is incorrect.</exception>
    public static void WriteLine(this IFluentOutput output, string? format, params object[] args)
    {
        if (format is null || args.Length < 1)
            return;
        string message;
        try
        {
            message = string.Format(format, args);
        }
        catch (FormatException exception)
        {
            throw new InvalidOutputFormat("Was not able to convert the format into a message.", exception);
        }
        IMessageRenderer renderer = new StringRenderer(message);
        output.WriteLine(renderer);
    }
}
