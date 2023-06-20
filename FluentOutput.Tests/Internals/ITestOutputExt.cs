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
    public static void Result<T>(this ITestOutputHelper output, T actual, T expected, Func<T, string?>? transform = null)
    {
        transform ??= DefaultTransform;
        string actualString = EnsureRepresentation(
            transform(actual));
        string expectedString = EnsureRepresentation(
            transform(expected));
        output.WriteLine(
            FormatOutput(actualString, expectedString));
    }
    static string? DefaultTransform<T>(T obj)
        => obj?.ToString();
    static string EnsureRepresentation(string? value)
    {
        if (value is null)
            return Null;
        if (value.Length < 1)
            return Empty;
        return value;
    }
    static string FormatOutput(string actual, string expected)
    {
        int valueLength = Math.Max(actual.Length, expected.Length);
        string format = BuildFormat(valueLength);
        StringBuilder builder = new();
        builder
            .AppendFormat(format, Expected, expected)
            .AppendLine()
            .AppendFormat(format, Actual, actual);
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
