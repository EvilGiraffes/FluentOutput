using FluentOutput.Sdk.Abstractions;

using Moq.Language.Flow;

namespace FluentOutput.Tests.Internals;
static class IExpectationFactoryMockExt
{
    public static ISetup<IExpectationFormatter, IMessageRenderer> SetupCreate(this Mock<IExpectationFormatter> factoryMock)
        => factoryMock.Setup(factory => factory.Build(It.IsAny<string>(), It.IsAny<string>()));
}
