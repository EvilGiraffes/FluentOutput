using FluentOutput.Formats.Helpers;

namespace FluentOutput.ExpectationConstraint;
/// <summary>
/// An <see cref="IExpectationConstraint{T}"/> where it uses <see cref="IExpectationFormatHelper"/>.
/// </summary>
/// <typeparam name="T"><inheritdoc cref="IExpectationConstraint{T}" path="/typeparam"/></typeparam>
public sealed class FormattedExpectationConstraint<T> : IExpectationConstraint<T>
{
    /// <inheritdoc/>
    public IExpectationFormatHelper FormatHelper { get; }
    /// <inheritdoc/>
    public T Actual { get; }
    /// <summary>
    /// Constructs a new instance of <see cref="FormattedExpectationConstraint{T}"/>.
    /// </summary>
    /// <param name="actual">The actual value given.</param>
    /// <param name="formatConstraint">The constraint to format according to.</param>
    public FormattedExpectationConstraint(T actual, IExpectationFormatHelper formatConstraint)
    {
        Actual = actual;
        FormatHelper = formatConstraint;
    }
}
