namespace Machete.HL7.Tests.Segments
{
    public static class MacheteSampleValueConverters
    {
        public static readonly IValueConverter<string> FormattedPhoneNumber = new PhoneNumberValueConverter();
    }
}