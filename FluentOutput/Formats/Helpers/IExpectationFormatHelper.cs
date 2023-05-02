using FluentOutput.ExpectationConstraint;

namespace FluentOutput.Formats.Helpers;
/// <summary>
/// Represents a constraint where a format will be added to <see cref="IExpectationConstraint{T}"/>
/// </summary>
public interface IExpectationFormatHelper
{
    /// <summary>
    /// Writes to the output given <paramref name="expected"/> and <paramref name="actual"/>.
    /// </summary>
    /// <param name="expected">The expected test value.</param>
    /// <param name="actual">The actual test value.</param>
    void WriteLine<T>(T expected, T actual);
}
