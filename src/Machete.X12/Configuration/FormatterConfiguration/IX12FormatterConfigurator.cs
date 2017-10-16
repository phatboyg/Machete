namespace Machete.X12.Configuration.FormatterConfiguration
{
    using Machete.FormatterConfiguration;


    public interface IX12FormatterConfigurator<TSchema> :
        IFormatterConfigurator<TSchema>
        where TSchema : X12Entity
    {
    }
}