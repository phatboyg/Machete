namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class PIMap :
        X12SegmentMap<PI, X12Entity>
    {
        public PIMap()
        {
            Id = "PI";
            Name = "Price Authority Identification";
            
            Value(x => x.ReferenceIdentificationQualifier, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.PrimaryPublicationAuthorityCode, 3, x => x.FixedLength(2));
            Value(x => x.RegulatoryAgencyCode, 4, x => x.MinLength(3).MaxLength(5));
            Value(x => x.TariffAgencyCode, 5, x => x.MinLength(1).MaxLength(4));
            Value(x => x.IssuingCarrierIdentifier, 6, x => x.MinLength(1).MaxLength(10));
            Value(x => x.ContractSuffix1, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TariffItemNumber, 8, x => x.MinLength(1).MaxLength(16));
            Value(x => x.TariffSupplementIdentifier, 9, x => x.MinLength(1).MaxLength(4));
            Value(x => x.TariffSectionNumber, 10, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ContractSuffix2, 11, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Date1, 12, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 13, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.AlternationPrecedenceCode1, 14, x => x.FixedLength(1));
            Value(x => x.AlternationPrecedenceCode2, 15, x => x.FixedLength(1));
            Value(x => x.ServiceLevelCode, 16, x => x.FixedLength(2));
        }
    }
}