namespace Machete
{
    using System;
    using Cursors;
    using Internals.Extensions;


    public static class ParsedCursorExtensions
    {
        /// <summary>
        /// Creates a <see cref="Cursor{T}"/> used to query the parsed result.
        /// </summary>
        /// <param name="entityResult">The parsed result</param>
        /// <typeparam name="TSchema">The schema type</typeparam>
        /// <returns>A new cursor, positioned at the start of the parsed result.</returns>
        public static Cursor<TSchema> GetCursor<TSchema>(this EntityResult<TSchema> entityResult)
            where TSchema : Entity
        {
            return new EntityResultCursor<TSchema>(entityResult);
        }

        /// <summary>
        /// Parse the parsed input from the beginning, create a new cursor, building the query on the fly
        /// </summary>
        /// <param name="entityResult"></param>
        /// <param name="buildQuery"></param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<TSchema>, TResult> Query<TSchema, TResult>(this EntityResult<TSchema> entityResult, QueryBuilderCallback<TSchema, TResult> buildQuery)
            where TSchema : Entity
        {
            var query = Query<TSchema>.Create(entityResult.Schema, buildQuery);

            var cursor = entityResult.GetCursor();

            return query.Parse(cursor);
        }

        /// <summary>
        /// Parse the parsed input from the beginning, create a new cursor, building the query on the fly
        /// </summary>
        /// <param name="entityResult"></param>
        /// <param name="query">The query parser</param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<TSchema>, TResult> Query<TSchema, TResult>(this EntityResult<TSchema> entityResult, IParser<TSchema, TResult> query)
            where TSchema : Entity
        {
            var cursor = entityResult.GetCursor();

            return query.Parse(cursor);
        }

        /// <summary>
        /// Parse the parsed input from the beginning, create a new cursor, building the query on the fly
        /// </summary>
        /// <param name="entityResult"></param>
        /// <param name="selector">The layout selector</param>
        /// <param name="options"></param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<TSchema>, TResult> Query<TSchema, TResult>(this EntityResult<TSchema> entityResult, QueryLayoutSelector<TSchema, TResult> selector,
            LayoutParserOptions options = LayoutParserOptions.None)
            where TSchema : Entity
            where TResult : Layout
        {
            if (!entityResult.Schema.TryGetLayout(out ILayoutParserFactory<TResult, TSchema> layout))
                throw new ArgumentException($"The layout was not found: {TypeCache<TResult>.ShortName}");

            IParser<TSchema, TResult> query = entityResult.CreateQuery(q => layout.CreateParser(options, q));

            var cursor = entityResult.GetCursor();

            return query.Parse(cursor);
        }
    }
}