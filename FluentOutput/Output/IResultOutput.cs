namespace FluentOutput.Output;
/// <summary>
/// Represents an output which handles it based upon expected and actual value.
/// </summary>
public interface IResultOutput
{
    /// <summary>
    /// Writes the result based on <paramref name="expected"/> and <paramref name="actual"/> values.
    /// </summary>
    /// <typeparam name="T">The type being tested.</typeparam>
    /// <param name="expected">The expected value from the test.</param>
    /// <param name="actual">The actual value from the test.</param>
    void WriteResult<T>(T expected, T actual)
        where T : notnull;
}
