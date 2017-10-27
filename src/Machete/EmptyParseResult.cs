namespace Machete
{
    using Texts;


    public class EmptyParseResult<TSchema> :
        ParseResult<TSchema>
        where TSchema : Entity
    {
        public EmptyParseResult(ISchema<TSchema> schema, IEntityParser<TSchema> parser, StreamText text, TextSpan remainingSpan)
        {
            Schema = schema;
            Parser = parser;
            RemainingText = text;
            RemainingSpan = remainingSpan;
        }
        
        public EmptyParseResult(ISchema<TSchema> schema, IEntityParser<TSchema> parser, ParseText text, TextSpan remainingSpan)
        {
            Schema = schema;
            Parser = parser;
            RemainingText = new StreamText(text, null);
            RemainingSpan = remainingSpan;
        }

        public bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema
        {
            entity = default;
            return false;
        }

        public ISchema<TSchema> Schema { get; }
        public IEntityParser<TSchema> Parser { get; }

        public StreamText RemainingText { get; }
        public TextSpan RemainingSpan { get; }

        public bool HasResult => false;
    }
}