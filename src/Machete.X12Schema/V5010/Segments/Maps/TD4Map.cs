namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class TD4Map :
        X12SegmentMap<TD4, X12Entity>
    {
        public TD4Map()
        {
            Id = "TD4";
            Name = "Carrier Details (Special Handling, or Hazardous Materials, or Both)";
            
            Value(x => x.SpecialHandlingCode, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.HazardousMaterialCodeQualifier, 2, x => x.FixedLength(1));
            Value(x => x.HazardousMaterialClassCode, 3, x => x.MinLength(1).MaxLength(4));
            Value(x => x.Description, 4, x => x.MinLength(1).MaxLength(80));
            Value(x => x.YesNoConditionOrResponseCode, 5, x => x.FixedLength(1));
        }
    }
}