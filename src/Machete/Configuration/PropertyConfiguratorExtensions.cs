namespace Machete
{
    public static class PropertyConfiguratorExtensions
    {
        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static IPropertyConfigurator Required(this IPropertyConfigurator configurator)
        {
            configurator.Required = true;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static IEntityPropertyConfigurator<T> Required<T>(this IEntityPropertyConfigurator<T> configurator)
        {
            configurator.Required = true;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static IDateTimePropertyConfigurator<T> Required<T>(this IDateTimePropertyConfigurator<T> configurator)
        {
            configurator.Required = true;

            return configurator;
        }
    }
}