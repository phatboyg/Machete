namespace Machete.HL7.FormatterConfiguration
{
    using Machete.FormatterConfiguration;


    public interface IHL7FormatterConfigurator<TSchema> :
        IFormatterConfigurator<TSchema>
        where TSchema : HL7Entity
    {
    }
}