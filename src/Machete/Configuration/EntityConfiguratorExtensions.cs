namespace Machete
{
    using SchemaConfiguration;


    public static class EntityConfiguratorExtensions
    {
        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true.
        /// </summary>
        public static IEntityLayoutConfigurator<TSchema, T> IsRequired<TSchema, T>(this IEntityLayoutConfigurator<TSchema, T> configurator)
            where TSchema : Entity
            where T : TSchema
        {
            configurator.Required = true;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to false.
        /// </summary>
        public static IEntityLayoutConfigurator<TSchema, T> IsOptional<TSchema, T>(this IEntityLayoutConfigurator<TSchema, T> configurator)
            where TSchema : Entity
            where T : TSchema
        {
            configurator.Required = false;

            return configurator;
        }
    }
}