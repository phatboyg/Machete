namespace Machete.HL7.Configuration.ParserConfiguration.Configurators
{
    using Machete.ParserConfiguration.Configurators;


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