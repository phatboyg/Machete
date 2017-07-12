namespace Machete.Parsers
{
    /// <summary>
    /// Matches an entity of the specified type
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public class EntityParser<TSchema, TEntity> :
        Parser<TSchema, TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly Parser<TSchema, TSchema> _parser;

        public EntityParser(Parser<TSchema, TSchema> parser)
        {
            _parser = parser;
        }

        public Result<Cursor<TSchema>, TEntity> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, TSchema> parsed = _parser.Parse(input);
            if (parsed.HasValue && parsed.Value is TEntity)
            {
                TEntity value = (TEntity) parsed.Value;

                return new Success<Cursor<TSchema>, TEntity>(value, parsed.Next);
            }

            return new Unmatched<Cursor<TSchema>, TEntity>(parsed.Next);
        }
    }
}