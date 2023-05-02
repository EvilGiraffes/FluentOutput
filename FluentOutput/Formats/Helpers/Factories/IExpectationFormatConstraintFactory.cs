using FluentOutput.Output;

namespace FluentOutput.Formats.Helpers.Factories;
/// <summary>
/// Represents a factory which creates a <see cref="IExpectationFormatHelper"/>.
/// </summary>
public interface IExpectationFormatConstraintFactory
{
    /// <summary>
    /// Creates a new instance of <see cref="IExpectationFormatHelper"/>.
    /// </summary>
    /// <param name="output">The output which <see cref="IExpectationFormatHelper"/> should wrap.</param>
    /// <param name="format">The format to use in this contraint.</param>
    /// <returns>A new <see cref="IExpectationFormatHelper"/>.</returns>
    IExpectationFormatHelper Create(IOutputProvider output, IExpectationFormat format);
}
