using FluentOutput.Formats.Helpers;

namespace FluentOutput.ExpectationConstraint.Factories;
/// <summary>
/// Creates instances of an <see cref="IExpectationConstraint{T}"/>.
/// </summary>
public interface IExpectationConstraintFactory
{
    /// <summary>
    /// Creates a new instance of <see cref="IExpectationConstraint{T}"/>.
    /// </summary>
    /// <param name="actual">The actual value given.</param>
    /// <param name="formatConstraint">The format it should use.</param>
    /// <returns>A new <see cref="IExpectationConstraint{T}"/>.</returns>
    IExpectationConstraint<T> Create<T>(T actual, IExpectationFormatHelper formatConstraint);
}
