namespace FluentOutput.Formats;
/// <summary>
/// Represents a format which uses a seperator to seperate the values.
/// </summary>
public interface ISeperatedFormat
{
    /// <summary>
    /// Will build the string according to the provided format.
    /// </summary>
    /// <typeparam name="T">The type being tested.</typeparam>
    /// <param name="expected">The expected value.</param>
    /// <param name="actual">The actual value.</param>
    /// <param name="seperator">The seperator to seperate <paramref name="expected"/> and <paramref name="actual"/>.</param>
    /// <returns>A new formatted <see cref="string"/>.</returns>
    string Build<T>(T expected, T actual, string seperator)
        where T : notnull;
}
