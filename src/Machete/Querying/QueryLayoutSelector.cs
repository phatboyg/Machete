namespace Machete
{
    public delegate Parser<TSchema, TResult> QueryLayoutSelector<TSchema, out TResult>(IQueryLayoutSelector<TSchema> selector);
}