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
    }
}