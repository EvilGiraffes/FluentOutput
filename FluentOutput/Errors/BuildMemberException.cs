namespace FluentOutput.Errors;
/// <summary>
/// Represents an exception when a member of the builder is incorrect.
/// </summary>
/// <typeparam name="T"><inheritdoc cref="BuildException{T}" path="/typeparam"/></typeparam>
public class BuildMemberException<T> : BuildException<T>
{
    /// <summary>
    /// The Parameter which was invalid.
    /// </summary>
    public string MemberName { get; }
    internal BuildMemberException(string memberName) : this(memberName, null)
    {
    }
    internal BuildMemberException(string memberName, string? message) : this(memberName, message, null)
    {
    }
    internal BuildMemberException(string memberName, string? message, Exception? innerException) : base(message, innerException)
    {
        MemberName = memberName;
    }
}
