namespace Machete
{
    /// <summary>
    /// Extension methods for creating queries using an existing Parsed
    /// </summary>
    public static class QueryExtensions
    {
        /// <summary>
        /// Create a query using the document to infer the schema type, which is not specifically tied to the document, but easy to discover.
        /// It's better to create a query using <see cref="Query{TSchema}.Create{T}"/> in advance, but really no difference.
        /// </summary>
        /// <param name="parsed">A parsed text</param>
        /// <param name="buildQuery">Callback to build the query</param>
        /// <typeparam name="T">The query result type</typeparam>
        /// <typeparam name="TSchema">The schema type</typeparam>
        /// <returns></returns>
        public static Parser<TSchema, T> CreateQuery<TSchema, T>(this Parsed<TSchema> parsed, QueryBuilderCallback<TSchema, T> buildQuery)
            where TSchema : Entity
        {
            return Query<TSchema>.Create(buildQuery);
        }

        /// <summary>
        /// Create a query using the document to infer the schema type, which is not specifically tied to the document, but easy to discover.
        /// It's better to create a query using <see cref="Query{TSchema}.Create{T}"/> in advance, but really no difference.
        /// </summary>
        /// <param name="parsed">A parsed text</param>
        /// <param name="parserFactory"></param>
        /// <param name="options"></param>
        /// <typeparam name="T">The query result type</typeparam>
        /// <typeparam name="TSchema">The schema type</typeparam>
        /// <returns></returns>
        public static Parser<TSchema, T> CreateQuery<TSchema, T>(this Parsed<TSchema> parsed, ILayoutParserFactory<T, TSchema> parserFactory,
            LayoutParserOptions options = LayoutParserOptions.None)
            where TSchema : Entity
            where T : Layout
        {
            return Query<TSchema>.Create(qb => parserFactory.CreateParser(options, qb));
        }
    }
}