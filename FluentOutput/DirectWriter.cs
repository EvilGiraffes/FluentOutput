using FluentOutput.Output;

namespace FluentOutput;
/// <summary>
/// Defines a single extention method for <see cref="IResultOutput"/> to write directly.
/// </summary>
public static class DirectWriter
{
    /// <summary>
    /// Writes the result directly.
    /// </summary>
    /// <typeparam name="T">The type being tested.</typeparam>
    /// <param name="output">The output currently in use.</param>
    /// <param name="expected">The expected value.</param>
    /// <param name="actual">The actual value.</param>
    public static void Result<T>(this IResultOutput output, T expected, T actual)
        where T : notnull
        => output.WriteResult(expected, actual);
}
