namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class CSHMap :
        X12SegmentMap<CSH, X12Entity>
    {
        public CSHMap()
        {
            Id = "CSH";
            Name = "Sales Requirements";
            
            Value(x => x.SalesRequirementCode, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.ActionCode, 2, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Amount, 3, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AccountNumber, 4, x => x.MinLength(1).MaxLength(35));
            Value(x => x.Date, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.AgencyQualifierCode, 6, x => x.FixedLength(2));
            Value(x => x.SpecialServicesCode, 7, x => x.MinLength(2).MaxLength(10));
            Value(x => x.ProductOrServiceSubstitutionCode, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PercentageAsDecimal, 9, x => x.MinLength(1).MaxLength(10));
            Value(x => x.PercentQualifier, 10, x => x.MinLength(1).MaxLength(2));
        }
    }
}