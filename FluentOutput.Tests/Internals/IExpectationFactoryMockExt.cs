using FluentOutput.MessageRenderers;
using FluentOutput.MessageRenderers.Expectation;

using Moq.Language.Flow;

namespace FluentOutput.Tests.Internals;
static class IExpectationFactoryMockExt
{
    public static ISetup<IExpectationRendererFactory, IMessageRenderer> SetupCreate(this Mock<IExpectationRendererFactory> factoryMock)
        => factoryMock.Setup(factory => factory.Create(It.IsAny<string>(), It.IsAny<string>()));
}
