namespace FluentOutput.Config.Options;
interface IOption<T>
{
    /// <summary>
    /// Returns to the previous configuration.
    /// </summary>
    /// <value>The parent configuration.</value>
    T Return { get; }
}
