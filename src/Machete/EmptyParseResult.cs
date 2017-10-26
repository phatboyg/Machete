namespace Machete
{
    using Texts;


    public class EmptyParseResult<TSchema> :
        ParseResult<TSchema>
        where TSchema : Entity
    {
        public EmptyParseResult(ISchema<TSchema> schema, StreamText text, TextSpan remainingSpan)
        {
            Schema = schema;
            RemainingText = text;
            RemainingSpan = remainingSpan;
        }

        public bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema
        {
            entity = default;
            return false;
        }

        public ISchema<TSchema> Schema { get; }

        public StreamText RemainingText { get; }

        public TextSpan RemainingSpan { get; }
    }
}