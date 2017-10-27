namespace Machete
{
    public delegate IParser<TSchema, TResult> QueryLayoutSelector<TSchema, out TResult>(IQueryLayoutSelector<TSchema> selector);
}