using FluentOutput.Transforms;

namespace FluentOutput.Tests.Transforms;
public sealed class NoValueHandlingTransformTests
{
    readonly ITestOutputHelper output;
    public NoValueHandlingTransformTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    [Fact]
    public void Transform_String_SameString()
    {
        NoValueHandlingTransform<string?> systemUnderTest = new();
        string expected = "Hello World!";
        string actual = systemUnderTest.Transform(expected);
        output.Result(actual, expected);
        actual.Should().Be(expected);
    }
    [Fact]
    public void Transform_Null_Null()
    {
        NoValueHandlingTransform<object?> systemUnderTest = new();
        string expected = "Null";
        string actual = systemUnderTest.Transform(null);
        output.Result(actual, expected);
        actual.Should().Be(expected);
    }
    [Fact]
    public void Transform_NotNull_ObjectString()
    {
        NoValueHandlingTransform<object?> systemUnderTest = new();
        string actual = systemUnderTest.Transform(new());
        actual.Should().NotBe("Null");
    }
    [Fact]
    public void Transform_Empty_Empty()
    {
        NoValueHandlingTransform<string?> systemUnderTest = new();
        string expected = "Empty";
        string actual = systemUnderTest.Transform(string.Empty);
        output.Result(actual, expected);
        actual.Should().Be(expected);
    }
    [Fact]
    public void Transform_NotEmpty_StringValue()
    {
        NoValueHandlingTransform<string?> systemUnderTest = new();
        string actual = systemUnderTest.Transform("a");
        actual.Should().NotBe("Empty");
    }
}
