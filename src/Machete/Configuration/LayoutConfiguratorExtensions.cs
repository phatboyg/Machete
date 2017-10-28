namespace Machete
{
    using SchemaConfiguration;


    public static class LayoutConfiguratorExtensions
    {
        public static ILayoutConfigurator<T> IsRequired<T>(this ILayoutConfigurator<T> configurator)
        {
            configurator.Required = true;

            return configurator;
        }
        
        public static ILayoutConfigurator<T> IsOptional<T>(this ILayoutConfigurator<T> configurator)
        {
            configurator.Required = false;

            return configurator;
        }
    }
}