namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C023Map :
        X12ComponentMap<C023, X12Entity>
    {
        public C023Map()
        {
            Value(x => x.PlaceOfServiceCode, 0, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.FacilityCodeQualifier, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ClaimFrequencyTypeCode, 2, x => x.FixedLength(1));
        }
    }
}