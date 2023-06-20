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
}
