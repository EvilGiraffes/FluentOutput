namespace FluentOutput;
/// <summary>
/// Represents a way to intercept certain functionality to use <see cref="IFluentOutput"/> on them.
/// </summary>
public static class Interceptors
{
    /// <summary>
    /// Intercepts <paramref name="act"/> to output with the exception given.
    /// </summary>
    /// <param name="act">The act to intercept.</param>
    /// <param name="handleException">The handler provided the exception. Output can be handled here.</param>
    /// <returns>A new <see cref="Action"/> which will throw the <see cref="Exception"/> if there is any.</returns>
    public static Action Intercept(this Action act, Action<Exception> handleException)
        => () =>
        {
            try
            {
                act();
            }
            catch (Exception exception)
            {
                handleException(exception);
                throw;
            }
        };
}
