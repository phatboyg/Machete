namespace Machete.X12Schema.V5010.Components
{
    using X12;
    using X12.Configuration;


    public class FacilityCodeComponentMap :
        X12ComponentMap<FacilityCodeComponent, X12Entity>
    {
        public FacilityCodeComponentMap()
        {
            Value(x => x.FacilityCodeValue, 0, x => x.MinLength(1).MaxLength(2).IsRequired());

            Value(x => x.FacilityCodeQualifier, 1, x => x.MinLength(1).MaxLength(2).IsRequired());

            Value(x => x.ClaimFrequencyTypeCode, 2, x => x.FixedLength(1));
        }
    }
}