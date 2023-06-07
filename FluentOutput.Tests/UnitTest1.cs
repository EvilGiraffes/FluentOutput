namespace FluentOutput.Tests;

public class UnitTest1
{
    readonly ITestOutputHelper output;
    readonly Mock<ITestOutputHelper> outputMock;
    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
        outputMock = new();
    }
    [Fact]
    public void Test1()
    {
        int actual = 1;
        actual.Should().Be(1);
    }
}