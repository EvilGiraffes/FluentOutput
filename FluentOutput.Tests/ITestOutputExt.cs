using System.Text;

namespace FluentOutput.Tests;
static class ITestOutputExt
{
    static int LongestFormat { get; } = Math.Max(Expected.Length, Actual.Length);
    const int Cushion = 1;
    const string Expected = "Expected";
    const string Actual = "Actual";
    const string Null = "Null";
    public static void Result<T>(this ITestOutputHelper output, T actual, T expected)
        => output.WriteLine(FormatOutput(actual, expected));
    static string FormatOutput<T>(T actual, T expected)
    {
        string actualString = actual?.ToString() ?? Null;
        string expectedString = expected?.ToString() ?? Null;
        int valueLength = Math.Max(actualString.Length, expectedString.Length);
        string format = BuildFormat(valueLength);
        StringBuilder builder = new();
        builder
            .AppendFormat(format, Expected, expectedString)
            .AppendLine()
            .AppendFormat(format, "Actual", actualString);
        return builder.ToString();
    }
    static string BuildFormat(int valueLength)
    {
        StringBuilder builder = new();
        builder
            .Append("{0,-")
            .Append(LongestFormat + Cushion)
            .Append("}:{1,")
            .Append(valueLength + Cushion)
            .Append('}');
        return builder.ToString();
    }
}
