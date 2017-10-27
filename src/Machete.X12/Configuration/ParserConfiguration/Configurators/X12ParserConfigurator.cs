namespace Machete.X12.Configuration.ParserConfiguration.Configurators
{
    using Machete.ParserConfiguration.Configurators;
    using Parsers;


    public class X12ParserConfigurator<TSchema> :
        ParserConfigurator<TSchema>,
        IX12ParserConfigurator
        where TSchema : X12Entity
    {
        public X12ParserConfigurator(ISchema<TSchema> schema)
            : base(schema)
        {
        }

        public IEntityParser<TSchema> Build()
        {
            return new X12EntityParser<TSchema>(Schema);
        }
    }
}