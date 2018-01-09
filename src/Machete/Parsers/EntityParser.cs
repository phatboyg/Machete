namespace Machete.Parsers
{
    using System;


    /// <summary>
    /// Matches an entity of the specified type
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public class EntityParser<TSchema, TEntity> :
        IParser<TSchema, TEntity>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly IParser<TSchema, TSchema> _parser;

        public EntityParser(IParser<TSchema, TSchema> parser)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        }

        public Result<Cursor<TSchema>, TEntity> Parse(Cursor<TSchema> input)
        {
            Result<Cursor<TSchema>, TSchema> parsed = _parser.Parse(input);
            if (!parsed.HasResult || !(parsed.Result is TEntity))
                return new Unmatched<Cursor<TSchema>, TEntity>(parsed.Next);
            
            TEntity value = (TEntity) parsed.Result;

            return new Success<Cursor<TSchema>, TEntity>(value, parsed.Next);
        }
    }
}