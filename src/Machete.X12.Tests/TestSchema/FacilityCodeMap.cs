namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class FacilityCodeMap :
        X12ComponentMap<FacilityCode, X12Entity>
    {
        public FacilityCodeMap()
        {
            Value(x => x.PlaceOfServiceCode, 0, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.FacilityCodeQualifier, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ClaimFrequencyTypeCode, 2, x => x.FixedLength(1));
        }
    }
}