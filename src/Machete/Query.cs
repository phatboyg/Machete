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
        /// Create a query on top of the specified schema
        /// </summary>
        /// <param name="buildQuery">Callback to build the query</param>
        /// <typeparam name="T">The query result type</typeparam>
        /// <returns>A parser containing the built query</returns>
        public static Parser<TSchema, T> Create<T>(Func<IQueryBuilder<TSchema>, Parser<TSchema, T>> buildQuery)
        {
            if (buildQuery == null)
                throw new ArgumentNullException(nameof(buildQuery));

            var queryBuilder= new QueryBuilder<TSchema>();

            Parser<TSchema, T> result = buildQuery(queryBuilder);
            if (result == null)
                throw new MacheteException("The query builder returned null");

            return result;
        }
    }
}