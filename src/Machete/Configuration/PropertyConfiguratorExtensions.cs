namespace Machete
{
    public static class PropertyConfiguratorExtensions
    {
        public static IPropertyConfigurator Required(this IPropertyConfigurator configurator)
        {
            configurator.Required = true;

            return configurator;
        }
        
        public static IEntityPropertyConfigurator<T> Required<T>(this IEntityPropertyConfigurator<T> configurator)
        {
            configurator.Required = true;

            return configurator;
        }
        
        public static IDateTimePropertyConfigurator<T> Required<T>(this IDateTimePropertyConfigurator<T> configurator)
        {
            configurator.Required = true;

            return configurator;
        }
    }
}