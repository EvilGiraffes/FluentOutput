namespace FluentOutput.Errors;
/// <summary>
/// Represents an exception thrown when the format for output is invalid.
/// </summary>
public class InvalidOutputFormat : FormatException
{
    internal InvalidOutputFormat()
    {
    }
    internal InvalidOutputFormat(string message) : base(message)
    {
    }
    internal InvalidOutputFormat(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
