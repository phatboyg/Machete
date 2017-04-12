namespace Cleaver
{
    public static class Parser
    {
        public static readonly IParserFactorySelector Factory = new UnusedParserFactorySelector();


        class UnusedParserFactorySelector :
            IParserFactorySelector
        {
        }
    }


    public abstract class Parser<TSchema> :
        IParser<TSchema>
        where TSchema : Entity
    {
        protected ISchema<TSchema> Schema { get; }

        protected Parser(ISchema<TSchema> schema)
        {
            Schema = schema;
        }

        public abstract Parsed<TSchema> Parse(TextCursor cursor);
    }
}