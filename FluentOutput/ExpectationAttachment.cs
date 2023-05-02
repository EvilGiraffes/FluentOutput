using FluentOutput.ExpectationConstraint;
using FluentOutput.ExpectationConstraint.Factories;
using FluentOutput.Formats;
using FluentOutput.Formats.Helpers;
using FluentOutput.Formats.Helpers.Factories;
using FluentOutput.Output;

namespace FluentOutput;
/// <summary>
/// Attaches <see cref="IExpectationConstraint{T}"/> to writers.
/// </summary>
public static class ExpectationAttachment
{
    /// <summary>
    /// The factory used to create <see cref="IExpectationConstraint{T}"/>'s in this attachment.
    /// </summary>
    /// <value>Default value is <see cref="FormattedExpectationConstraintFactory"/>.</value>
    public static IExpectationConstraintFactory ExpectationConstraintFactory { get; set; } = new FormattedExpectationConstraintFactory();
    /// <summary>
    /// The factory used to create <see cref="IExpectationFormatHelper"/>'s in this attachment.
    /// </summary>
    /// <value>Default value is <see cref="ExpectationFormattedHelperFactory"/>.</value>
    public static IExpectationFormatConstraintFactory FormatConstraintFactory { get; set; } = new ExpectationFormattedHelperFactory();
    /// <summary>
    /// The default format if nothing is provided.
    /// </summary>
    /// <value>Default value is <see cref="ColonExpectationFormat"/> with the seperator default seperator.</value>
    public static IExpectationFormat DefaultFormat { get; set; } = new ColonExpectationFormat();
    /// <summary>
    /// Adds a format to the <see cref="IExpectationFormatHelper"/>.
    /// </summary>
    /// <param name="output">The output provider for this attachment.</param>
    /// <param name="format">The format to use.</param>
    /// <returns>a new <see cref="IExpectationFormatHelper"/>.</returns>
    public static IExpectationFormatHelper WithFormat(IOutputProvider output, IExpectationFormat format)
        => FormatConstraintFactory.Create(output, format);
    /// <summary>
    /// Writes according to an actual value.
    /// </summary>
    /// <typeparam name="T">The type where it is expected.</typeparam>
    /// <param name="formatConstraint">The formatting which is wished to be used.</param>
    /// <param name="actual">The actual value given.</param>
    /// <returns>A new <see cref="IExpectationConstraint{T}"/> for further processing.</returns>
    public static IExpectationConstraint<T> Expecting<T>(this IExpectationFormatHelper formatConstraint, T actual)
        => ExpectationConstraintFactory.Create(actual, formatConstraint);
    /// <summary>
    /// <inheritdoc cref="Expecting{T}(IExpectationFormatHelper, T)" path="/summary"/>
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="Expecting{T}(IExpectationFormatHelper, T)" path="/typeparam"/></typeparam>
    /// <param name="output">The output provider to delegate outputs to.</param>
    /// <param name="actual"><inheritdoc cref="Expecting{T}(IExpectationFormatHelper, T)" path="/param[@name='actual']"/></param>
    /// <returns><inheritdoc cref="Expecting{T}(IExpectationFormatHelper, T)" path="/returns"/></returns>
    public static IExpectationConstraint<T> Expecting<T>(this IOutputProvider output, T actual)
    {
        IExpectationFormatHelper formatConstraint = FormatConstraintFactory.Create(output, DefaultFormat);
        return Expecting(formatConstraint, actual);
    }
}
