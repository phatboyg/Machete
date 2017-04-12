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
    }
}