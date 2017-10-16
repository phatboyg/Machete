namespace Machete.X12.Configuration.SchemaConfiguration
{
    using Machete.SchemaConfiguration;


    public interface IX12SchemaConfigurator<in TSchema> :
        ISchemaConfigurator<TSchema>
        where TSchema : X12Entity
    {
    }
}