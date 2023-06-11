using System.Text;

namespace FluentOutput.Tests.Internals;
static class ITestOutputExt
{
    static int LongestFormat { get; } = Math.Max(Expected.Length, Actual.Length);
    const int Cushion = 1;
    const string Expected = "Expected";
    const string Actual = "Actual";
    const string Null = "Null";
    const string Empty = "Empty String";
    public static void Result<T>(this ITestOutputHelper output, T actual, T expected)
        => output.WriteLine(FormatOutput(actual, expected));
    static string FormatOutput<T>(T actual, T expected)
    {
        string actualString = CreateStringFrom(actual);
        string expectedString = CreateStringFrom(expected);
        int valueLength = Math.Max(actualString.Length, expectedString.Length);
        string format = BuildFormat(valueLength);
        StringBuilder builder = new();
        builder
            .AppendFormat(format, Expected, expectedString)
            .AppendLine()
            .AppendFormat(format, Actual, actualString);
        return builder.ToString();
    }
    static string CreateStringFrom<T>(T value)
    {
        string? valueString = value?.ToString();
        if (valueString is null)
            return Null;
        if (valueString.Length <= 0)
            return Empty;
        return valueString;
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
