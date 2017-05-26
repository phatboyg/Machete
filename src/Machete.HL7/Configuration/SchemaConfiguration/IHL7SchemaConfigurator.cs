namespace Machete.HL7.Configuration.SchemaConfiguration
{
    using Machete.SchemaConfiguration;


    public interface IHL7SchemaConfigurator<in TSchema> :
        ISchemaConfigurator<TSchema>
        where TSchema : HL7Entity
    {
    }
}