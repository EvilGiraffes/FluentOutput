using FluentOutput.ExpectationConstraint;

namespace FluentOutput;
/// <summary>
/// Collection of extentions for <see cref="IExpectationConstraint{T}"/> where the generic value is a <see cref="bool"/>.
/// </summary>
public static class BooleanWriters
{
    /// <summary>
    /// Expects the actual value to be <see langword="true"/>.
    /// </summary>
    /// <param name="expectationConstraint">The <see cref="bool"/> <see cref="IExpectationConstraint{T}"/> to write to.</param>
    public static void ToBeTrue(this IExpectationConstraint<bool> expectationConstraint)
        => expectationConstraint.ToBe(true);
    /// <summary>
    /// Expects the actual value to be <see langword="false"/>.
    /// </summary>
    /// <param name="expectationConstraint"><inheritdoc cref="ToBeTrue(IExpectationConstraint{bool})" path="/param[@name='expectationConstraint']"/></param>
    public static void ToBeFalse(this IExpectationConstraint<bool> expectationConstraint)
        => expectationConstraint.ToBe(false);
}
