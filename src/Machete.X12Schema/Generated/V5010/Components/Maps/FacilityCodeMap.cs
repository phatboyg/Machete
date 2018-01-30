namespace Machete.X12Schema.V5010.Components.Maps
{
    using X12;
    using X12.Configuration;


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