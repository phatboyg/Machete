namespace Machete
{
    using System;
    using SchemaConfiguration;
    using Values.Converters;


    public static class ValueConverterConfigurationExtensions
    {
        public static IPropertyConfigurator<DateTimeOffset> LongDate(this IPropertyConfigurator<DateTimeOffset> configurator)
        {
            configurator.Converter = ValueConverters.DateTimeOffset;

            return configurator;
        }

        public static IPropertyConfigurator<DateTime> LongDate(this IPropertyConfigurator<DateTime> configurator)
        {
            configurator.Converter = ValueConverters.LongDate;

            return configurator;
        }

        public static IPropertyConfigurator<DateTime> LongDateTime(this IPropertyConfigurator<DateTime> configurator)
        {
            configurator.Converter = ValueConverters.LongDateTime;

            return configurator;
        }

        public static IPropertyConfigurator<DateTime> LongDateTimeWithSeconds(this IPropertyConfigurator<DateTime> configurator)
        {
            configurator.Converter = ValueConverters.LongDateTimeWithSeconds;

            return configurator;
        }

        public static IPropertyConfigurator<DateTime> ShortDate(this IPropertyConfigurator<DateTime> configurator)
        {
            configurator.Converter = ValueConverters.ShortDate;

            return configurator;
        }

        public static IPropertyConfigurator<DateTime> ShortDateTime(this IPropertyConfigurator<DateTime> configurator)
        {
            configurator.Converter = ValueConverters.ShortDateTime;

            return configurator;
        }

        public static IPropertyConfigurator<DateTime> ShortDateTimeWithSeconds(this IPropertyConfigurator<DateTime> configurator)
        {
            configurator.Converter = ValueConverters.ShortDateTimeWithSeconds;

            return configurator;
        }

        public static IPropertyConfigurator<DateTime> Time(this IPropertyConfigurator<DateTime> configurator)
        {
            configurator.Converter = ValueConverters.Time;

            return configurator;
        }

        public static IPropertyConfigurator<TimeSpan> TimeWithSeconds(this IPropertyConfigurator<TimeSpan> configurator)
        {
            configurator.Converter = ValueConverters.TimeWithSeconds;

            return configurator;
        }
    }
}