namespace Machete.HL7.Tests.TestSchema
{
    public static class MacheteSampleValueConverters
    {
        public static readonly IValueConverter<string> FormattedPhoneNumber = new PhoneNumberValueConverter();
    }
}