using FluentOutput.ExpectationConstraint;

namespace FluentOutput;
/// <summary>
/// Collection of extention methods for <see cref="IExpectationConstraint{T}"/> where it writes directly.
/// </summary>
public static class DirectWriters
{
    /// <summary>
    /// What you expect the value to be.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="IExpectationConstraint{T}" path="/typeparam"/></typeparam>
    /// <param name="expectationConstraint">The constraint where the actual value resides.</param>
    /// <param name="expected">The value expected.</param>
    public static void ToBe<T>(this IExpectationConstraint<T> expectationConstraint, T expected)
        => expectationConstraint.FormatHelper
        .WriteLine(expected, expectationConstraint.Actual);
}
