namespace Machete
{
    public interface IQueryBuilder<TSchema>
        where TSchema : Entity
    {
        QueryParser<TSchema, T> Select<T>()
            where T : TSchema;
    }
}