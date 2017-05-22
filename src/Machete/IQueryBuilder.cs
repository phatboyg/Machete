namespace Machete
{
    public interface IQueryBuilder<TSchema>
        where TSchema : Entity
    {
        QueryParser<TSchema, T> Select<T>()
            where T : TSchema;

        QueryParser<TSchema, T> Except<T, TExcept>()
            where T : TSchema
            where TExcept : TSchema;

        QueryParser<TSchema, T> Except<T, TExcept>(Parser<TSchema, TExcept> except)
            where T : TSchema;
    }
}