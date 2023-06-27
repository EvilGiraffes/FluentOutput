using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;

namespace FluentOutput.Sdk.SectionWriters;
/// <summary>
/// Represents a <see cref="ISectionWriterFactory{TWriter}"/> which creates <see cref="TypeWriter{TContext}"/>.
/// </summary>
public sealed class TypeWriterFactory : ISectionWriterFactory<ITypeWriter>
{
    /// <inheritdoc/>
    public ITypeWriter Create<TContext>(TContext actual, IExpectationRenderHandler renderer)
        => new TypeWriter<TContext>(actual, renderer);
}
