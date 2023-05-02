namespace FluentOutput.Formats;
/// <summary>
/// Represents a <see cref="IExpectationFormat"/> which is seperated by a colon (:).
/// </summary>
public sealed class ColonExpectationFormat : IExpectationFormat
{
    readonly string seperator;
    /// <summary>
    /// Constructs a new <see cref="ColonExpectationFormat"/> with the <paramref name="seperator"/>.
    /// </summary>
    /// <param name="seperator">What to seperate the values with.</param>
    public ColonExpectationFormat(string seperator)
    {
        this.seperator = seperator;
    }
    /// <summary>
    /// Constructs a new <see cref="ColonExpectationFormat"/> with a seperator of <see cref="Environment.NewLine"/>.
    /// </summary>
    public ColonExpectationFormat() : this(Environment.NewLine)
    {
    }
    /// <inheritdoc/>
    public string Build(string expected, string actual)
        => $"Expected: {expected}{seperator}Actual: {actual}";
}
