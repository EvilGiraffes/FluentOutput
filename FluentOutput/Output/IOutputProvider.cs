namespace FluentOutput.Output;
/// <summary>
/// A provider for the test output.
/// </summary>
public interface IOutputProvider
{
    /// <summary>
    /// Will write the <paramref name="message"/> to the output.
    /// </summary>
    /// <param name="message">What to write to the output.</param>
    void WriteLine(string message);
}
