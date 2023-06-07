namespace FluentOutput.Errors;
/// <summary>
/// Represents an exception when a build fails.
/// </summary>
/// <typeparam name="T">The type which is being built.</typeparam>
public class BuildException<T> : Exception
{
    /// <inheritdoc/>
    public override string Message
        => $"Building of {typeof(T).Name} failed. {base.Message}";
    internal BuildException()
    {
    }
    internal BuildException(string? message) : base(message)
    {
    }
    internal BuildException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
