namespace FluentOutput.Formatting;
/// <summary>
/// Represents a formatter which contains a format and takes in arguments to the formatter.
/// </summary>
public interface IOutputFormatter
{
    /// <summary>
    /// Checks if this instance can format with the given <paramref name="args"/>.
    /// </summary>
    /// <param name="args">The arguments to put in the format.</param>
    /// <returns><see langword="true"/> if this instance can format with the given <paramref name="args"/>, <see langword="false"/> if it can't.</returns>
    bool CanFormat(object[] args);
    /// <summary>
    /// Formats a <see cref="string"/> given the <paramref name="args"/>.
    /// </summary>
    /// <param name="args"><inheritdoc cref="CanFormat(object[])" path="/param[@name='args']"/></param>
    /// <returns>A new formatted <see cref="string"/>.</returns>
    /// <exception cref="FormatException">Thrown if the <paramref name="args"/> is not valid for this formatter. Use <see cref="CanFormat(object[])"/> to avoid this exception.</exception>
    string Format(object[] args);
}
