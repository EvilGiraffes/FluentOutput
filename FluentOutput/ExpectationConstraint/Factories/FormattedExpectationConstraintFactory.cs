using FluentOutput.Formats.Helpers;

namespace FluentOutput.ExpectationConstraint.Factories;
/// <summary>
/// Creates instances of <see cref="FormattedExpectationConstraint{T}"/>.
/// </summary>
public sealed class FormattedExpectationConstraintFactory : IExpectationConstraintFactory
{
    /// <inheritdoc/>
    public IExpectationConstraint<T> Create<T>(T actual, IExpectationFormatHelper formatConstraint)
        => new FormattedExpectationConstraint<T>(actual, formatConstraint);
}
