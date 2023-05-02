using FluentOutput.Output;

namespace FluentOutput.Formats.Helpers;
/// <summary>
/// Creates a formatted <see cref="IExpectationFormatHelper"/> using an <see cref="IExpectationFormat"/>.
/// </summary>
public sealed class ExpectationFormattedHelper : IExpectationFormatHelper
{
    readonly IOutputProvider output;
    readonly IExpectationFormat format;
    const string Null = "null";
    /// <summary>
    /// Constructs a new <see cref="ExpectationFormattedHelper"/> with the specified <see cref="IExpectationFormat"/>.
    /// </summary>
    /// <param name="output">The provided test output.</param>
    /// <param name="format">The format to format the expectation according to.</param>
    public ExpectationFormattedHelper(IOutputProvider output, IExpectationFormat format)
    {
        this.output = output;
        this.format = format;
    }
    /// <inheritdoc/>
    public void WriteLine<T>(T expected, T actual)
    {
        string formattedOutput = format.Build(Transform(expected), Transform(actual));
        output.WriteLine(formattedOutput);
    }
    static string Transform<T>(T value)
        => value?.ToString() ?? Null;
}
