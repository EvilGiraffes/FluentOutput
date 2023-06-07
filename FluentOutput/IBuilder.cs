using FluentOutput.Errors;
namespace FluentOutput;
interface IBuilder<T>
{
    /// <summary>
    /// Builds a new instance of <typeparamref name="T"/>.
    /// </summary>
    /// <returns>An instance of <typeparamref name="T"/></returns>
    /// <exception cref="BuildException{T}">Thrown when the build failed.</exception>
    T Build();
}
