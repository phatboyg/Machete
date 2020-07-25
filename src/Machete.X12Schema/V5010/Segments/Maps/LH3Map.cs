namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LH3Map :
        X12SegmentMap<LH3, X12Entity>
    {
        public LH3Map()
        {
            Id = "LH3";
            Name = "Hazardous Material Shipping Name";
            
            Value(x => x.HazardousMaterialShippingName, 1, x => x.MinLength(1).MaxLength(25));
            Value(x => x.HazardousMaterialShippingNameQualifier, 2, x => x.FixedLength(1));
            Value(x => x.NotOtherwiseSpecifiedIndicatorCode, 3, x => x.FixedLength(3));
            Value(x => x.YesNoConditionOrResponseCode, 4, x => x.FixedLength(1));
        }
    }
}