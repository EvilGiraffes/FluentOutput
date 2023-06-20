using System.Diagnostics.CodeAnalysis;

using FluentOutput.Errors;

namespace FluentOutput.MessageRenderers.Expectation;
/// <summary>
/// Represents a builder for <see cref="DoubleSeperatedExpectationRenderer"/>.
/// </summary>
/// <remarks>
/// <para>
/// Required methods to call: <br/>
/// <see cref="Actual(string?)"/> <br/>
/// <see cref="Expected(string?)"/>
/// </para>
/// <para>
/// Optional methods to call: <br/>
/// <see cref="ValueSeperator(char)"/> = ':' <br/>
/// <see cref="LineSeperator(string)"/> = <see cref="Environment.NewLine"/>
/// </para>
/// </remarks>
public sealed class DoubleSeperatedExpectationBuilder : IBuilder<DoubleSeperatedExpectationRenderer>
{
    string? actual = default;
    string? expected = default;
    char? valueSeperator = default;
    string? lineSeperator = default;
    internal static string DefaultLineSeperator { get; } = Environment.NewLine;
    internal const char DefaultValueSeperator = ';';
    internal DoubleSeperatedExpectationBuilder()
    {
    }
    /// <summary>
    /// Sets the actual value for the <see cref="DoubleSeperatedExpectationRenderer"/>.
    /// </summary>
    /// <param name="actual">The actual value.</param>
    /// <returns><see langword="this"/> for further processing.</returns>
    public DoubleSeperatedExpectationBuilder Actual(string actual)
    {
        this.actual = actual;
        return this;
    }
    /// <summary>
    /// Sets the expected value for the <see cref="DoubleSeperatedExpectationRenderer"/>.
    /// </summary>
    /// <param name="expected">The expected value.</param>
    /// <returns><inheritdoc cref="Actual(string?)" path="/returns"/></returns>
    public DoubleSeperatedExpectationBuilder Expected(string expected)
    {
        this.expected = expected;
        return this;
    }
    /// <summary>
    /// Sets the value seperator for the <see cref="DoubleSeperatedExpectationRenderer"/>.
    /// </summary>
    /// <param name="valueSeperator">The seperator between the value and title.</param>
    /// <returns><inheritdoc cref="Actual(string?)" path="/returns"/></returns>
    public DoubleSeperatedExpectationBuilder ValueSeperator(char valueSeperator)
    {
        this.valueSeperator = valueSeperator;
        return this;
    }
    /// <summary>
    /// Sets the line seperator for the <see cref="DoubleSeperatedExpectationRenderer"/>.
    /// </summary>
    /// <param name="lineSeperator">The seperator for each line.</param>
    /// <returns><inheritdoc cref="Actual(string?)" path="/returns"/></returns>
    public DoubleSeperatedExpectationBuilder LineSeperator(string lineSeperator)
    {
        this.lineSeperator = lineSeperator;
        return this;
    }
    /// <inheritdoc/>
    public DoubleSeperatedExpectationRenderer Build()
    {
        if (actual is null)
            ThrowBuildMemberNull(nameof(actual));
        if (expected is null)
            ThrowBuildMemberNull(nameof(expected));
        valueSeperator ??= DefaultValueSeperator;
        lineSeperator ??= DefaultLineSeperator;
        return new DoubleSeperatedExpectationRenderer(actual, expected, (char) valueSeperator, lineSeperator);
    }
    [DoesNotReturn]
    static void ThrowBuildMemberNull(string memberName)
        => throw new BuildMemberNull<DoubleSeperatedExpectationRenderer>(memberName);
}
