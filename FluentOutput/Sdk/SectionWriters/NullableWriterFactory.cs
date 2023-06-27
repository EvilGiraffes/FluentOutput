using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;

namespace FluentOutput.Sdk.SectionWriters;
/// <summary>
/// Represents a <see cref="ISectionWriterFactory{TWriter}"/> which returns <see cref="NullableWriter{TContext}"/>.
/// </summary>
public sealed class NullableWriterFactory : ISectionWriterFactory<INullabilityWriter>
{
    /// <inheritdoc/>
    public INullabilityWriter Create<TContext>(TContext actual, IExpectationRenderHandler renderer)
        => new NullableWriter<TContext>(actual, renderer);
}
