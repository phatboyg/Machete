namespace Machete
{
    public interface IQueryLayoutSelector<TSchema>
    {
        IParser<TSchema, TResult> Layout<TResult>();
    }
}