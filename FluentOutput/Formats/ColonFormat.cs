namespace FluentOutput.Formats;
/// <summary>
/// Represents a <see cref="ISeperatedFormat"/> which is seperated by a colon (:).
/// </summary>
public sealed class ColonFormat : ISeperatedFormat
{
    /// <inheritdoc/>
    public string Build<T>(T expected, T actual, string seperator)
        where T : notnull
        => $"Expected {expected}{seperator}Actual: {actual}";
}
