namespace Machete
{
    public delegate Parser<TSchema, TResult> QueryBuilderCallback<TSchema, out TResult>(IQueryBuilder<TSchema> builder)
        where TSchema : Entity;
}