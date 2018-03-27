namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class HealthcareCodeMap :
        X12ComponentMap<HealthcareCode, X12Entity>
    {
        public HealthcareCodeMap()
        {
            Value(x => x.DiagnosisTypeCode, 0, x => x.MinLength(1).MaxLength(3));
            Value(x => x.DiagnosisCode, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.DateTimePeriodFormatQualifier, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.DateTimePeriod, 3, x => x.Converter = X12ValueConverters.DateTimePeriod);
            Value(x => x.MonetaryAmount, 4, x => x.MinLength(1).MaxLength(18));
            Value(x => x.Quantity, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.VersionIdentifier, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.IndustryCode, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ResponseCode, 8, x => x.FixedLength(1));
        }
    }
}