namespace FluentOutput.Errors;
/// <summary>
/// Represents an exception where the member has a null value.
/// </summary>
/// <typeparam name="T"><inheritdoc cref="BuildMemberException{T}" path="/typeparam"/></typeparam>
public class BuildMemberNull<T> : BuildMemberException<T>
{
    internal BuildMemberNull(string memberName) : base(memberName)
    {
    }

    internal BuildMemberNull(string memberName, string message) : base(memberName, message)
    {
    }

    internal BuildMemberNull(string memberName, string message, Exception innerException) : base(memberName, message, innerException)
    {
    }
}
