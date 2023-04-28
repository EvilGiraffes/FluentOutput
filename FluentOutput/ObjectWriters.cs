using FluentOutput.Output;

namespace FluentOutput;
/// <summary>
/// Collection of extentions for <see cref="IResultOutput"/> for a <see langword="class"/>.
/// </summary>
public static class ObjectWriters
{
    const string Null = "null";
    const string NotNull = "notnull";
    /// <summary>
    /// Writes to the output expecting <paramref name="actual"/> to be <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="DirectWriter.Result{T}(IResultOutput, T, T)" path="/typeparam"/></typeparam>
    /// <param name="output"><inheritdoc cref="DirectWriter.Result{T}(IResultOutput, T, T)" path="/param[@name='output']"/></param>
    /// <param name="actual">The actual value expected.</param>
    public static void ExpectingNull<T>(this IResultOutput output, T actual)
        where T : class
    {
        string actualResult = TransformNull(actual);
        output.WriteResult(Null, actualResult);
    }
    /// <summary>
    /// Writes to the output expecting <paramref name="actual"/> to be not <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="ExpectingNull{T}(IResultOutput, T)" path="/typeparam"/></typeparam>
    /// <param name="output"><inheritdoc cref="ExpectingNull{T}(IResultOutput, T)" path="/param[@name='output']"/></param>
    /// <param name="actual"><inheritdoc cref="ExpectingNull{T}(IResultOutput, T)" path="/param[@name='actual']"/></param>
    public static void ExpectingNotNull<T>(this IResultOutput output, T actual)
        where T : class
    {
        string actualResult = TransformNull(actual);
        output.WriteResult(NotNull, actualResult);
    }
    static string TransformNull<T>(T value)
    {
        if (value is null)
            return Null;
        return NotNull;
    }
}
