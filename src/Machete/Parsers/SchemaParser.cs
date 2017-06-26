namespace Machete.Parsers
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Texts;


    public abstract class SchemaParser<TSchema> :
        IParser<TSchema>
        where TSchema : Entity
    {
        public ISchema<TSchema> Schema { get; }

        protected SchemaParser(ISchema<TSchema> schema)
        {
            Debug.Assert(schema != null);

            Schema = schema;
        }

        public abstract ParseResult<TSchema> Parse(ParseText text, TextSpan span);
        public abstract Task<ParseResult<TSchema>> ParseAsync(StreamText text, TextSpan span);
    }
}