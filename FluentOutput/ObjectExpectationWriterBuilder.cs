using System.Diagnostics.CodeAnalysis;

using FluentOutput.Errors;
using FluentOutput.Sdk.Abstractions;
using FluentOutput.Sdk.Abstractions.SectionWriters;

namespace FluentOutput;
sealed class ObjectExpectationWriterBuilder : IBuilder<ObjectExpectationWriter>
{
    object? actual = null;
    IExpectationRenderHandler? renderer = null;
    INullabilityWriter? nullabilityWriter = null;
    ITypeWriter? typeWriter = null;
    public ObjectExpectationWriterBuilder Actual(object? actual)
    {
        this.actual = actual;
        return this;
    }
    public ObjectExpectationWriterBuilder Renderer(IExpectationRenderHandler renderer)
    {
        this.renderer = renderer;
        return this;
    }
    public ObjectExpectationWriterBuilder NullabilityWriter(INullabilityWriter factory)
    {
        nullabilityWriter = factory;
        return this;
    }
    public ObjectExpectationWriterBuilder TypeWriter(ITypeWriter factory)
    {
        typeWriter = factory;
        return this;
    }
    public ObjectExpectationWriter Build()
    {
        if (RequiredNull())
        {
            string member = GetNullMember();
            throw new BuildMemberNull<ObjectExpectationWriter>(member);
        }
        return new(actual, renderer, nullabilityWriter, typeWriter);
    }
    [MemberNotNullWhen(false, nameof(renderer), nameof(nullabilityWriter), nameof(typeWriter))]
    bool RequiredNull()
        => renderer is null
        || nullabilityWriter is null
        || typeWriter is null;
    string GetNullMember()
    {
        if (renderer is null)
            return nameof(renderer);
        if (nullabilityWriter is null)
            return nameof(nullabilityWriter);
        if (typeWriter is null)
            return nameof(typeWriter);
        return "None";
    }
}
