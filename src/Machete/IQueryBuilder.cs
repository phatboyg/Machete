namespace Machete
{
    public interface IQueryBuilder<TSchema>
        where TSchema : Entity
    {
        Parser<TSchema, T> Select<T>()
            where T : TSchema;
    }
}