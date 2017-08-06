namespace Machete.HL7.ParserConfiguration.Configurators
{
    using Machete.ParserConfiguration.Configurators;
    using Parsers;


    public class HL7ParserConfigurator<TSchema> :
        ParserConfigurator<TSchema>,
        IHL7ParserConfigurator
        where TSchema : HL7Entity
    {
        public HL7ParserConfigurator(ISchema<TSchema> schema)
            : base(schema)
        {
        }

        public IParser<TSchema> Build()
        {
            return new HL7Parser<TSchema>(Schema);
        }
    }
}