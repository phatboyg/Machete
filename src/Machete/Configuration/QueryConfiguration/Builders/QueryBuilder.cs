namespace Machete.QueryConfiguration.Builders
{
    using Parsers;


    public class QueryBuilder<TSchema> :
        IQueryBuilder<TSchema>
        where TSchema : Entity
    {
        public Parser<TSchema, T> Select<T>()
            where T : TSchema
        {
            return new EntityParser<TSchema, T>(new AnyParser<TSchema>());
        }
    }
}