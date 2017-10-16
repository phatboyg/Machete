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
            Set(x => x.IsEmpty, IsComponentEmpty, x => x.NoFormat());

            Value(x => x.Fields, 1, x =>
            {
                x.SetRange();
                x.NoFormat();
            });

            IEntityConfigurator<TComponent, TSchema> entityConfigurator = this;

            entityConfigurator.FormatterFactory = formatters => new X12ComponentFormatter<TComponent, TSchema>(formatters);
        }

        static bool IsComponentEmpty(TextSlice slice)
        {
            return !slice.TryGetSlice(1, out var _);
        }
    }
}