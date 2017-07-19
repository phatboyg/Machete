namespace Machete
{
    public interface IQueryLayoutSelector<TSchema>
    {
        Parser<TSchema, TResult> Layout<TResult>();
    }
}