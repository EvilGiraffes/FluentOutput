namespace FluentOutput.ResultFormatters;
/// <summary>
/// Represents a formatter based on expectation and actual values.
/// </summary>
public interface IResultFormatter
{
    /// <summary>
    /// Formats the result output according to the given format.
    /// </summary>
    /// <typeparam name="T">The type being tested.</typeparam>
    /// <param name="expected">The expected result.</param>
    /// <param name="actual">The actual result.</param>
    /// <returns>A formatted <see cref="string"/> based on the provided values.</returns>
    public string Format<T>(T expected, T actual)
        where T : notnull;
}
