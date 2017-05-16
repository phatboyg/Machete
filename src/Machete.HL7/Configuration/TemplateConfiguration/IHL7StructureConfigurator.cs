namespace Machete.HL7.Configuration.TemplateConfiguration
{
    using Machete.TemplateConfiguration;


    public interface IHL7StructureConfigurator<TSchema> :
        IStructureConfigurator<TSchema>
        where TSchema : HL7Entity
    {
    }
}