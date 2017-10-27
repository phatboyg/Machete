namespace Machete.Parsers
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Texts;


    public abstract class SchemaEntityParser<TSchema> :
        IEntityParser<TSchema>
        where TSchema : Entity
    {
        public ISchema<TSchema> Schema { get; }

        protected SchemaEntityParser(ISchema<TSchema> schema)
        {
            Debug.Assert(schema != null);

            Schema = schema;
        }

        public abstract ParseResult<TSchema> Parse(ParseText text, TextSpan span);
        public abstract Task<ParseResult<TSchema>> ParseAsync(StreamText text, TextSpan span);
    }
}