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
    }
}