namespace FluentOutput;
// TODO: Implement properly.
static class ExceptionAttachment
{
    public static Action Intercept(this IFluentOutput output, Action act, Action<IFluentOutput, Exception> handleOutput)
        => () =>
        {
            try
            {
                act();
            }
            catch (Exception exception)
            {
                handleOutput(output, exception);
                throw;
            }
        };
}
