namespace Machete
{
    using System;


    /// <summary>
    /// Extension methods for creating queries using an existing Parsed
    /// </summary>
    public static class QueryExtensions
    {
        /// <summary>
        /// Create a query using the document to infer the schema type, which is not specifically tied to the document, but easy to discover.
        /// It's better to create a query using <see cref="Query{TSchema}.Create{T}"/> in advance, but really no difference.
        /// </summary>
        /// <param name="entityResult">A parsed text</param>
        /// <param name="buildQuery">Callback to build the query</param>
        /// <typeparam name="T">The query result type</typeparam>
        /// <typeparam name="TSchema">The schema type</typeparam>
        /// <returns></returns>
        public static IParser<TSchema, T> CreateQuery<TSchema, T>(this EntityResult<TSchema> entityResult, QueryBuilderCallback<TSchema, T> buildQuery)
            where TSchema : Entity
        {
            if (entityResult == null)
                throw new ArgumentNullException(nameof(entityResult));
            
            return Query<TSchema>.Create(entityResult.Schema, buildQuery);
        }

        /// <summary>
        /// Create a query using the document to infer the schema type, which is not specifically tied to the document, but easy to discover.
        /// It's better to create a query using <see cref="Query{TSchema}.Create{T}"/> in advance, but really no difference.
        /// </summary>
        /// <param name="schema">A parsed text</param>
        /// <param name="buildQuery">Callback to build the query</param>
        /// <typeparam name="T">The query result type</typeparam>
        /// <typeparam name="TSchema">The schema type</typeparam>
        /// <returns></returns>
        public static IParser<TSchema, T> CreateQuery<TSchema, T>(this ISchema<TSchema> schema, QueryBuilderCallback<TSchema, T> buildQuery)
            where TSchema : Entity
        {
            return Query<TSchema>.Create(schema, buildQuery);
        }

        /// <summary>
        /// Create a query using the document to infer the schema type, which is not specifically tied to the document, but easy to discover.
        /// It's better to create a query using <see cref="Query{TSchema}.Create{T}"/> in advance, but really no difference.
        /// </summary>
        /// <param name="entityResult">A parsed text</param>
        /// <param name="parserFactory"></param>
        /// <param name="options"></param>
        /// <typeparam name="T">The query result type</typeparam>
        /// <typeparam name="TSchema">The schema type</typeparam>
        /// <returns></returns>
        public static IParser<TSchema, T> CreateQuery<TSchema, T>(this EntityResult<TSchema> entityResult, ILayoutParserFactory<T, TSchema> parserFactory,
            LayoutParserOptions options = LayoutParserOptions.None)
            where TSchema : Entity
            where T : Layout
        {
            if (entityResult == null)
                throw new ArgumentNullException(nameof(entityResult));
            
            if (parserFactory == null)
                throw new ArgumentNullException(nameof(parserFactory));
            
            return Query<TSchema>.Create(entityResult.Schema, qb => parserFactory.CreateParser(options, qb));
        }

        /// <summary>
        /// Create a query using the document to infer the schema type, which is not specifically tied to the document, but easy to discover.
        /// It's better to create a query using <see cref="Query{TSchema}.Create{T}"/> in advance, but really no difference.
        /// </summary>
        /// <param name="schema">A parsed text</param>
        /// <param name="parserFactory"></param>
        /// <param name="options"></param>
        /// <typeparam name="T">The query result type</typeparam>
        /// <typeparam name="TSchema">The schema type</typeparam>
        /// <returns></returns>
        public static IParser<TSchema, T> CreateQuery<TSchema, T>(this ISchema<TSchema> schema, ILayoutParserFactory<T, TSchema> parserFactory,
            LayoutParserOptions options = LayoutParserOptions.None)
            where TSchema : Entity
            where T : Layout
        {
            if (parserFactory == null)
                throw new ArgumentNullException(nameof(parserFactory));
            
            return Query<TSchema>.Create(schema, qb => parserFactory.CreateParser(options, qb));
        }
    }
}