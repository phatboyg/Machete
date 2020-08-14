namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class X1Map :
        X12SegmentMap<X1, X12Entity>
    {
        public X1Map()
        {
            Id = "X1";
            Name = "Export License";
            
            Value(x => x.CodeForLicensingCertificationRegistrationOrAccreditationAgency, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ExportLicenseNumber, 2, x => x.MinLength(6).MaxLength(35));
            Value(x => x.ExportLicenseStatusCode, 3, x => x.FixedLength(1));
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ExportLicenseSymbolCode, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ExportLicenseControlCode, 6, x => x.FixedLength(1));
            Value(x => x.CountryCode, 7, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ScheduleBCode, 8, x => x.MinLength(7).MaxLength(10));
            Value(x => x.InternationalOrDomesticCode, 9, x => x.FixedLength(1));
            Value(x => x.LadingQuantity, 10, x => x.MinLength(1).MaxLength(7));
            Value(x => x.LadingValue, 11, x => x.MinLength(2).MaxLength(9));
            Value(x => x.ExportFilingKeyCode, 12, x => x.FixedLength(1));
            Value(x => x.UnitOrBasisOfMeasurement, 13, x => x.FixedLength(2));
            Value(x => x.UnitPrice, 14, x => x.MinLength(1).MaxLength(17));
            Value(x => x.UnitedStatesGovernmentLicenseType, 15, x => x.FixedLength(1));
            Value(x => x.IdentificationCode, 16, x => x.MinLength(2).MaxLength(80));
            Value(x => x.LocationIdentifier, 17, x => x.MinLength(1).MaxLength(30));
        }
    }
}