namespace Machete
{
    using Cursors;


    public static class ParsedCursorExtensions
    {
        /// <summary>
        /// Creates a <see cref="Cursor{T}"/> used to query the parsed result.
        /// </summary>
        /// <param name="parsed">The parsed result</param>
        /// <typeparam name="TSchema">The schema type</typeparam>
        /// <returns>A new cursor, positioned at the start of the parsed result.</returns>
        public static Cursor<TSchema> GetCursor<TSchema>(this Parsed<TSchema> parsed)
            where TSchema : Entity
        {
            return new ParsedCursor<TSchema>(parsed);
        }

        /// <summary>
        /// Parse the parsed input from the beginning, create a new cursor, building the query on the fly
        /// </summary>
        /// <param name="parsed"></param>
        /// <param name="buildQuery"></param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<TSchema>, TResult> Query<TSchema, TResult>(this Parsed<TSchema> parsed, QueryBuilderCallback<TSchema, TResult> buildQuery)
            where TSchema : Entity
        {
            var query = Query<TSchema>.Create(buildQuery);

            var cursor = parsed.GetCursor();

            return query.Parse(cursor);
        }

        /// <summary>
        /// Parse the parsed input from the beginning, create a new cursor, building the query on the fly
        /// </summary>
        /// <param name="parsed"></param>
        /// <param name="query">The query parser</param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<TSchema>, TResult> Query<TSchema, TResult>(this Parsed<TSchema> parsed, Parser<TSchema, TResult> query)
            where TSchema : Entity
        {
            var cursor = parsed.GetCursor();

            return query.Parse(cursor);
        }
    }
}