using FluentOutput.Config.Options;

namespace FluentOutput.Config;
/// <summary>
/// Master class to configure the package to your own needs.
/// </summary>
public static class FluentOutputConfigurations
{
    /// <summary>
    /// Contains the configurations for this package.
    /// </summary>
    public static ConfigurationOptions Options { get; } = new();
    /// <summary>
    /// Sets up the configurations with the given <paramref name="setup"/>.
    /// </summary>
    /// <param name="setup">The action to perform the setup in.</param>
    public static void Setup(Action<ConfigurationOptions> setup)
        => setup(Options);
}
