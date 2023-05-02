using FluentOutput.Output;

namespace FluentOutput.Formats.Helpers.Factories;
/// <summary>
/// Creates instances of <see cref="ExpectationFormattedHelper"/>.
/// </summary>
public sealed class ExpectationFormattedHelperFactory : IExpectationFormatConstraintFactory
{
    /// <inheritdoc/>
    public IExpectationFormatHelper Create(IOutputProvider output, IExpectationFormat format)
        => new ExpectationFormattedHelper(output, format);
}
