using FluentOutput.Output;

namespace FluentOutput;
/// <summary>
/// Collection of extentions for <see cref="IResultOutput"/> for <see cref="bool"/> values.
/// </summary>
public static class BooleanWriters
{
    /// <summary>
    /// Writes output expecting <paramref name="actual"/> to be <see langword="true"/>.
    /// </summary>
    /// <param name="output"><inheritdoc cref="DirectWriter.Result{T}(IResultOutput, T, T)" path="/param[@name='output']"/></param>
    /// <param name="actual">The actual <see cref="bool"/>.</param>
    public static void ExpectingTrue(this IResultOutput output, bool actual)
        => output.WriteResult(true, actual);
    /// <summary>
    /// Writes output expecting <paramref name="actual"/> to be <see langword="false"/>.
    /// </summary>
    /// <param name="output"><inheritdoc cref="ExpectingTrue(IResultOutput, bool)" path="/param[@name='output']"/></param>
    /// <param name="actual"><inheritdoc cref="ExpectingTrue(IResultOutput, bool)" path="/param[@name='actual']"/></param>
    public static void ExpectingFalse(this IResultOutput output, bool actual)
        => output.WriteResult(false, actual);
}
