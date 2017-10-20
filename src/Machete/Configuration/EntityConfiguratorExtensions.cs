namespace Machete
{
    using SchemaConfiguration;


    public static class EntityConfiguratorExtensions
    {
        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static IEntityConfigurator<T> IsRequired<T>(this IEntityConfigurator<T> configurator)
            where T : Entity
        {
            configurator.Required = true;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to false
        /// </summary>
        public static IEntityConfigurator<T> IsOptional<T>(this IEntityConfigurator<T> configurator)
            where T : Entity
        {
            configurator.Required = false;

            return configurator;
        }
    }
}