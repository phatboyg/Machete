namespace Machete.HL7
{
    using System;
    using Machete.SchemaConfiguration;


    public static class HL7ValueTypeConverterExtensions
    {
        public static IPropertyConfigurator<DateTimeOffset> LongDateTimeOffset(this IPropertyConfigurator<DateTimeOffset> configurator)
        {
            configurator.Converter = HL7ValueConverters.VariableLongDateTime;
            configurator.Formatter = HL7ValueFormatters.LongDateTimeOffset;

            return configurator;
        }
    }
}