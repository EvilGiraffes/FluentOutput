using FluentOutput.Formats.Helpers;

namespace FluentOutput.ExpectationConstraint;
// TODO: Use this instead of all this Result attachment thing.
/// <summary>
/// A constraint where there is an expectation to the value.
/// </summary>
/// <typeparam name="T">The type with an expectation.</typeparam>
public interface IExpectationConstraint<T>
{
    /// <summary>
    /// The actual value given.
    /// </summary>
    T Actual { get; }
    /// <summary>
    /// The formatting constraint given with this object.
    /// </summary>
    IExpectationFormatHelper FormatHelper { get; }
}
