namespace Machete.HL7
{
    using Formatters;
    using Machete.SchemaConfiguration;


    public class HL7ComponentMap<TComponent, TSchema> :
        HL7EntityMap<TComponent, TSchema>
        where TComponent : TSchema, HL7Component
        where TSchema : HL7Entity
    {
        protected HL7ComponentMap()
        {
            IEntityConfigurator<TComponent, TSchema> entityConfigurator = this;

            entityConfigurator.FormatterFactory = formatters => new HL7ComponentFormatter<TComponent, TSchema>(formatters);
        }
    }
}