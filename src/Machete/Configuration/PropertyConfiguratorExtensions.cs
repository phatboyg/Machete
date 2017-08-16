namespace Machete
{
    using SchemaConfiguration;


    public static class PropertyConfiguratorExtensions
    {
        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static IPropertyConfigurator IsRequired(this IPropertyConfigurator configurator)
        {
            configurator.Required = true;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static IEntityPropertyConfigurator<T> IsRequired<T>(this IEntityPropertyConfigurator<T> configurator)
        {
            configurator.Required = true;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static IDateTimePropertyConfigurator<T> IsRequired<T>(this IDateTimePropertyConfigurator<T> configurator)
        {
            configurator.Required = true;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to false
        /// </summary>
        public static IPropertyConfigurator IsOptional(this IPropertyConfigurator configurator)
        {
            configurator.Required = false;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to false
        /// </summary>
        public static IEntityPropertyConfigurator<T> IsOptional<T>(this IEntityPropertyConfigurator<T> configurator)
        {
            configurator.Required = false;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to false
        /// </summary>
        public static IDateTimePropertyConfigurator<T> IsOptional<T>(this IDateTimePropertyConfigurator<T> configurator)
        {
            configurator.Required = false;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> <see cref="IPropertyConfigurator.MaxLength"/> to <paramref name="maxLength"/>
        /// </summary>
        public static IPropertyConfigurator MaxLength(this IPropertyConfigurator configurator, int maxLength)
        {
            configurator.MaxLength = maxLength;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> <see cref="IEntityPropertyConfigurator{T}.MaxLength"/> to <paramref name="maxLength"/>
        /// </summary>
        public static IEntityPropertyConfigurator<T> MaxLength<T>(this IEntityPropertyConfigurator<T> configurator, int maxLength)
        {
            configurator.MaxLength = maxLength;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> <see cref="IDateTimePropertyConfigurator{T}.MaxLength"/> to <paramref name="maxLength"/>
        /// </summary>
        public static IDateTimePropertyConfigurator<T> MaxLength<T>(this IDateTimePropertyConfigurator<T> configurator, int maxLength)
        {
            configurator.MaxLength = maxLength;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> <see cref="IPropertyConfigurator.MinLength"/> to <paramref name="minLength"/>
        /// </summary>
        public static IPropertyConfigurator MinLength(this IPropertyConfigurator configurator, int minLength)
        {
            configurator.MinLength = minLength;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> <see cref="IEntityPropertyConfigurator{T}.MinLength"/> to <paramref name="minLength"/>
        /// </summary>
        public static IEntityPropertyConfigurator<T> MinLength<T>(this IEntityPropertyConfigurator<T> configurator, int minLength)
        {
            configurator.MinLength = minLength;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> <see cref="IDateTimePropertyConfigurator{T}.MinLength"/> to <paramref name="minLength"/>
        /// </summary>
        public static IDateTimePropertyConfigurator<T> MinLength<T>(this IDateTimePropertyConfigurator<T> configurator, int minLength)
        {
            configurator.MinLength = minLength;

            return configurator;
        }

        /// <summary>
        /// Sets <paramref name="configurator"/> Required to true
        /// </summary>
        public static IPropertyConfigurator NoFormat(this IPropertyConfigurator configurator)
        {
            configurator.Formatting = FormatOptions.Exclude;

            return configurator;
        }
    }
}