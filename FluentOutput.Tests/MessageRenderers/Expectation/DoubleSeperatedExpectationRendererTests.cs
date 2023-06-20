using FluentOutput.MessageRenderers.Expectation;

namespace FluentOutput.Tests.MessageRenderers.Expectation;
public sealed class DoubleSeperatedExpectationRendererTests
{
    readonly ITestOutputHelper output;
    public DoubleSeperatedExpectationRendererTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    [Fact]
    public void Render_SelectedValues_FormatsCorrectly()
    {
        const string injectedExpected = "Hello!";
        const string injectedActual = "World!";
        const char valueSeperator = ':';
        const string lineSeperator = " -> ";
        const string expected = "Expecting : Hello! -> Actual : World!";
        DoubleSeperatedExpectationRenderer systemUnderTest = new(injectedActual, injectedExpected, valueSeperator, lineSeperator);
        string actual = systemUnderTest.Render();
        output.Result(actual, expected, value =>
        {
            if (value is null)
                return null;
            return $"[{value}]";
        });
        actual.Should().Be(expected);
    }
}
