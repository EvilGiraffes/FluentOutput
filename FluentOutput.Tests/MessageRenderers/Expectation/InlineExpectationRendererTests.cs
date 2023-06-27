using FluentOutput.MessageRenderers.Expectation;

namespace FluentOutput.Tests.MessageRenderers.Expectation;
public sealed class InlineExpectationRendererTests
{
    readonly ITestOutputHelper output;
    public InlineExpectationRendererTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    [Fact]
    public void Render_SingleSeperator_FormatsCorrectly()
    {
        string injectedActual = "Hello!";
        string injectedExpected = "World!";
        string seperator = ":";
        int cushion = 1;
        string expected = $"Expected : World!{Environment.NewLine}Actual   : Hello!";
        InlineExpectationRenderer systemUnderTest = new(injectedActual, injectedExpected, seperator, cushion);
        string actual = systemUnderTest.Render();
        output.Result(actual, expected, value =>
        {
            if (value is null)
                return null;
            return $"[{Environment.NewLine}{value}{Environment.NewLine}]";
        });
        actual.Should().Be(expected);
    }
    [Theory]
    [InlineData(0)]
    [InlineData(int.MaxValue)]
    public void Ctor_ValidCushion_NoException(int cushion)
    {
        Action act = () => _ = Create(cushion);
        act.Should().NotThrow();
    }
    [Theory]
    [InlineData(-1)]
    [InlineData(int.MinValue)]
    public void Ctor_InvalidCushion_Exception(int cushion)
    {
        Action act = () => _ = Create(cushion);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
    static InlineExpectationRenderer Create(int cushion)
        => new(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), cushion);
}
