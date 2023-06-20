namespace FluentOutput.Transforms.Delegate;
sealed class DelegateTransformAdapter<T> : ITransform<T>
{
    readonly Func<T, string> adapted;
    public DelegateTransformAdapter(Func<T, string> adapted)
    {
        this.adapted = adapted;
    }
    public string Transform(T input)
        => adapted(input);
}
