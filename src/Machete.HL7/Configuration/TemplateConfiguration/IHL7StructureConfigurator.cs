namespace Machete.HL7.Configuration.TemplateConfiguration
{
    using StructureConfiguration;


    public interface IHL7StructureConfigurator<TSchema> :
        IStructureConfigurator<TSchema>
        where TSchema : HL7Entity
    {
    }
}