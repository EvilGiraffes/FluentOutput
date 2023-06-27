namespace FluentOutput.Sdk.Abstractions;
/// <summary>
/// Represents a formatter to build a <see cref="IMessageRenderer"/>.
/// </summary>
public interface IExpectationFormatter
{
    /// <summary>
    /// Formats the input and constructs it as a <see cref="IMessageRenderer"/>.
    /// </summary>
    /// <param name="actual">The actual value.</param>
    /// <param name="expected">The expecting value.</param>
    /// <returns>A new instance of <see cref="IMessageRenderer"/> which formats with the given <paramref name="actual"/> and <paramref name="expected"/>.</returns>
    public IMessageRenderer Build(string actual, string expected);
}
