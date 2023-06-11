using FluentOutput.Contexts;
using FluentOutput.MessageRenderers;
using FluentOutput.MessageRenderers.Expectation;
using FluentOutput.Transforms;

namespace FluentOutput.Tests.Contexts;
public sealed class ExpectationContextTests
{
    readonly ITestOutputHelper output;
    readonly Mock<IFluentOutput> fluentOutputMock;
    readonly Mock<IExpectationRendererFactory> rendererFactoryMock;
    readonly Mock<IMessageRenderer> rendererMock;
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
        const int actualValue = 5;
        const int expectedValue = 6;
        const string expected = "5 6";
        string actual = string.Empty;
        rendererFactoryMock
            .SetupCreate()
            .Returns(rendererMock.Object)
            .Callback(
                (string interceptedActual, string interceptedExpected)
                => actual = $"{interceptedActual} {interceptedExpected}");
        ExpectationRenderFactoryContext<int> systemUnderTest = CreateContext(actualValue);
        systemUnderTest.Render(expectedValue);
        output.Result(actual, expected);
        actual.Should().Be(expected);
    }
    [Fact]
    public void Render_Transform_TransformsArguments()
    {
        Mock<ITransform<int>> transformMock = new();
        const int actualValue = 5;
        const int expectedValue = 6;
        const string expected = "Transformed(5) Transformed(6)";
        Func<int, string> transform = integrer => $"Transformed({integrer})";
        transformMock
            .Setup(transformer => transformer.Transform(It.IsAny<int>()))
            .Returns(transform);
        string actual = string.Empty;
        rendererFactoryMock
            .SetupCreate()
            .Returns(rendererMock.Object)
            .Callback(
                (string interceptedActual, string interceptedExpected)
                => actual = $"{interceptedActual} {interceptedExpected}");
        ExpectationRenderFactoryContext<int> systemUnderTest = CreateContext(actualValue);
        systemUnderTest.Render(expectedValue, transformMock.Object);
        output.Result(actual, expected);
        actual.Should().Be(expected);
    }
    [Fact]
    public void Render_Null_NullRepresented()
    {
        string expected = "Null Null";
        string actual = string.Empty;
        rendererFactoryMock
            .SetupCreate()
            .Returns(rendererMock.Object)
            .Callback(
                (string interceptedActual, string interceptedExpected)
                => actual = $"{interceptedActual} {interceptedExpected}");
        ExpectationRenderFactoryContext<object?> systemUnderTest = CreateContext<object?>(null);
        systemUnderTest.Render(null);
        output.Result(actual, expected);
        actual.Should().Be(expected);
    }
    ExpectationRenderFactoryContext<T> CreateContext<T>(T actual)
        => new(fluentOutputMock.Object, actual, rendererFactoryMock.Object);
}
