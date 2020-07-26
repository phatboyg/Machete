namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TAXMap :
        X12SegmentMap<TAX, X12Entity>
    {
        public TAXMap()
        {
            Id = "TAX";
            Name = "Advertising Demographic Information";
            
            Value(x => x.TaxIdentificationNumber, 1, x => x.MinLength(1).MaxLength(20));
            Value(x => x.LocationQualifier1, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier1, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.LocationQualifier2, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier2, 5, x => x.MinLength(1).MaxLength(30));
            Value(x => x.LocationQualifier3, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier3, 7, x => x.MinLength(1).MaxLength(30));
            Value(x => x.LocationQualifier4, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier4, 9, x => x.MinLength(1).MaxLength(30));
            Value(x => x.LocationQualifier5, 10, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier5, 11, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TaxExemptCode, 12, x => x.FixedLength(1));
            Value(x => x.CustomsEntryTypeGroupCode, 13, x => x.FixedLength(1));
        }
    }
}