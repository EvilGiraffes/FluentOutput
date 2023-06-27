namespace FluentOutput.Sdk.Abstractions.SectionWriters;
/// <summary>
/// Represents a writer which writes according to nullability of the type.
/// </summary>
public interface INullabilityWriter
{
    /// <summary>
    /// Writes if the current actual value is null.
    /// </summary>
    void ToBeNull();
    /// <summary>
    /// Writes if the current actual value is not null.
    /// </summary>
    void ToNotBeNull();
}
