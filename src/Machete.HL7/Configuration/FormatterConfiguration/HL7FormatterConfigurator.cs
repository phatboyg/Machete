namespace Machete.HL7.FormatterConfiguration
{
    using Formatters;
    using Machete.FormatterConfiguration;
    using Machete.Formatters;


    public class HL7FormatterConfigurator<TSchema> :
        FormatterConfigurator<TSchema>,
        IHL7FormatterConfigurator<TSchema>
        where TSchema : HL7Entity
    {
        public HL7FormatterConfigurator(ISchema<TSchema> schema)
            : base(schema)
        {
        }

        public IFormatter<TSchema> Build()
        {
            return new HL7Formatter<TSchema>(Schema);
        }
    }
}