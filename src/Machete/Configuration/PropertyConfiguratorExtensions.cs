namespace Machete
{
    using SchemaConfiguration;


    public static class PropertyConfiguratorExtensions
    {
        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static TConfigurator IsRequired<TConfigurator>(this TConfigurator configurator)
            where TConfigurator : IPropertyConfigurator
        {
            configurator.Required = true;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to false
        /// </summary>
        public static TConfigurator IsOptional<TConfigurator>(this TConfigurator configurator)
            where TConfigurator : IPropertyConfigurator
        {
            configurator.Required = false;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> <see cref="IPropertyConfigurator.MaxLength"/> to <paramref name="maxLength"/>
        /// </summary>
        public static TConfigurator MaxLength<TConfigurator>(this TConfigurator configurator, int maxLength)
            where TConfigurator : IPropertyConfigurator
        {
            configurator.MaxLength = maxLength;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> <see cref="IPropertyConfigurator.MinLength"/> to <paramref name="minLength"/>
        /// </summary>
        public static TConfigurator MinLength<TConfigurator>(this TConfigurator configurator, int minLength)
            where TConfigurator : IPropertyConfigurator
        {
            configurator.MinLength = minLength;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Formatting to exclude this property
        /// </summary>
        public static TConfigurator NoFormat<TConfigurator>(this TConfigurator configurator)
            where TConfigurator : IPropertyConfigurator
        {
            configurator.Formatting = FormatOptions.Exclude;

            return configurator;
        }
    }
}