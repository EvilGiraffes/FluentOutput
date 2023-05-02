namespace FluentOutput.Formats;
/// <summary>
/// Represents a format with expectation and actual values.
/// </summary>
public interface IExpectationFormat
{
    /// <summary>
    /// Will build the string according to the provided format.
    /// </summary>
    /// <param name="expected">The expected value.</param>
    /// <param name="actual">The actual value.</param>
    /// <returns>A new formatted <see cref="string"/>.</returns>
    string Build(string expected, string actual);
}
