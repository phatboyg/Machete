namespace Machete
{
    public delegate IParser<TSchema, TResult> QueryBuilderCallback<TSchema, out TResult>(IQueryBuilder<TSchema> builder)
        where TSchema : Entity;
}