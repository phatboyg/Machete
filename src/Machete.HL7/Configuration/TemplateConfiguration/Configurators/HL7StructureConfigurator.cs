namespace Machete.HL7.Configuration.TemplateConfiguration.Configurators
{
    using StructureConfiguration.Configurators;


    public class HL7StructureConfigurator<TSchema> :
        StructureConfigurator<TSchema>,
        IHL7StructureConfigurator<TSchema>
        where TSchema : HL7Entity
    {
        public HL7StructureConfigurator(ISchema<TSchema> schema)
            : base(schema)
        {
        }
    }
}