using FluentOutput.ExpectationConstraint;

namespace FluentOutput;
/// <summary>
/// Collection of extention methods for <see cref="IExpectationConstraint{T}"/> for any nullable types.
/// </summary>
public static class NullWriters
{
    const string Null = "null";
    const string NotNull = "notnull";
    /// <summary>
    /// Expects the actual value to be <see langword="null"/>
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="IExpectationConstraint{T}" path="/typeparam"/></typeparam>
    /// <param name="expectationConstraint">The constraint containing the actual value.</param>
    public static void ToBeNull<T>(this IExpectationConstraint<T> expectationConstraint)
        => WriteNullAsString(expectationConstraint, Null);
    /// <summary>
    /// Expects the actual value to be not <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="ToBeNull{T}(IExpectationConstraint{T})" path="/typeparam"/></typeparam>
    /// <param name="expectationConstraint"><inheritdoc cref="ToBeNull{T}(IExpectationConstraint{T})" path="/param[@name='expectationConstraint']"/></param>
    public static void ToBeNotNull<T>(this IExpectationConstraint<T> expectationConstraint)
        => WriteNullAsString(expectationConstraint, NotNull);
    static void WriteNullAsString<T>(IExpectationConstraint<T> expectationConstraint, string expected)
    {
        string actual = expectationConstraint.Actual is null ? Null : NotNull;
        expectationConstraint.FormatHelper.WriteLine(expected, actual);
    }
}
