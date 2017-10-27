namespace Machete.QueryConfiguration.Builders
{
    using Parsers;


    public class QueryBuilder<TSchema> :
        IQueryBuilder<TSchema>
        where TSchema : Entity
    {
        public QueryParser<TSchema, T> Select<T>()
            where T : TSchema
        {
            return new EntityQueryParser<TSchema, T>(new EntityParser<TSchema, T>(new AnyParser<TSchema>()));
        }

        QueryParser<TSchema, T> IQueryBuilder<TSchema>.Except<T, TExcept>()
        {
            return new EntityQueryParser<TSchema, T>(new EntityParser<TSchema, T>(new AnyParser<TSchema>()).Except(new EntityParser<TSchema, TExcept>(new AnyParser<TSchema>())));
        }

        QueryParser<TSchema, T> IQueryBuilder<TSchema>.Except<T, TExcept>(IParser<TSchema, TExcept> except)
        {
            return new EntityQueryParser<TSchema, T>(new EntityParser<TSchema, T>(new AnyParser<TSchema>()).Except(except));
        }
    }
}