namespace Machete
{
    using System;
    using QueryConfiguration.Builders;


    /// <summary>
    /// Entrypoint for creating a schema query
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public static class Query<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Create a query parser, which can be used to query a parsed document into a matching structure.
        /// </summary>
        /// <param name="schema">The query schema</param>
        /// <param name="buildQuery">Callback to build the query</param>
        /// <typeparam name="T">The query result type</typeparam>
        /// <returns>A parser containing the built query</returns>
        public static IParser<TSchema, T> Create<T>(ISchema<TSchema> schema, QueryBuilderCallback<TSchema, T> buildQuery)
        {
            if (schema == null)
                throw new ArgumentNullException(nameof(schema));
            
            if (buildQuery == null)
                throw new ArgumentNullException(nameof(buildQuery));

            var queryBuilder = new QueryBuilder<TSchema>(schema);

            IParser<TSchema, T> result = buildQuery(queryBuilder);
            if (result == null)
                throw new MacheteException("The query builder returned null");

            return result;
        }
    }
}