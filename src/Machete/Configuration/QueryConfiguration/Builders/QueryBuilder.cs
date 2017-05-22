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

        public QueryParser<TSchema, T> Except<T, TExcept>()
            where T : TSchema
            where TExcept : TSchema
        {
            return new EntityQueryParser<TSchema, T>(new EntityParser<TSchema, T>(new AnyParser<TSchema>()).Except(new EntityParser<TSchema, TExcept>(new AnyParser<TSchema>())));
        }

        public QueryParser<TSchema, T> Except<T, TExcept>(Parser<TSchema, TExcept> except)
            where T : TSchema
        {
            return new EntityQueryParser<TSchema, T>(new EntityParser<TSchema, T>(new AnyParser<TSchema>()).Except(except));
        }
    }
}