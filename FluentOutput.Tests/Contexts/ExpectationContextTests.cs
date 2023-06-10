using FluentOutput.Contexts;
using FluentOutput.MessageRenderers;
using FluentOutput.MessageRenderers.Expectation;

namespace FluentOutput.Tests.Contexts;
public sealed class ExpectationContextTests
{
    readonly ITestOutputHelper output;
    readonly Mock<IFluentOutput> fluentOutputMock;
    readonly Mock<IExpectationRendererFactory> rendererFactoryMock;
    readonly Mock<IMessageRenderer> rendererMock;
    const string ExpectationFormat = "[ Expected : {0}, Actual : {1} ]";
    public ExpectationContextTests(ITestOutputHelper output)
    {
        this.output = output;
        fluentOutputMock = new();
        rendererFactoryMock = new();
        rendererMock = new();
    }
    [Fact]
    public void Render_NoTransform_FormatsToOutputCorrectly()
    {
        const int value = 5;
        string expected = string.Format(ExpectationFormat, value, value);
        string actual = string.Empty;
        InterceptFactory(
            (interceptedActual, interceptedExpected)
            => actual = string.Format(ExpectationFormat, interceptedExpected, interceptedActual));
        ExpectationContext<int> systemUnderTest = CreateContext(value);
        systemUnderTest.Render(value);
        output.Result(actual, expected);
        actual.Should().Be(expected);
    }
    ExpectationContext<T> CreateContext<T>(T value)
        => new(fluentOutputMock.Object, value, rendererFactoryMock.Object);
    void InterceptFactory(Action<string, string> interceptor)
        => rendererFactoryMock
        .Setup(factory => factory.Create(It.IsAny<string>(), It.IsAny<string>()))
        .Returns(rendererMock.Object)
        .Callback(interceptor);
}
