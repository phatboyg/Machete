namespace Machete.X12.Configuration
{
    using Formatters;
    using Machete.SchemaConfiguration;


    public class X12ComponentMap<TComponent, TSchema> :
        X12EntityMap<TComponent, TSchema>
        where TComponent : TSchema, X12Component
        where TSchema : X12Entity
    {
        protected X12ComponentMap()
        {
            IEntityConfigurator<TComponent, TSchema> entityConfigurator = this;

            entityConfigurator.FormatterFactory = formatters => new X12ComponentFormatter<TComponent, TSchema>(formatters);
        }
    }
}