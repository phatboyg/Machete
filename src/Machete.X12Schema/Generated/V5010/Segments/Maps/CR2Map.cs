namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CR2Map :
        X12SegmentMap<CR2, X12Entity>
    {
        public CR2Map()
        {
            Id = "CR2";
            Name = "Spinal Manipulation Service Information";
            
            Value(x => x.PatientConditionCode, 8, x => x.FixedLength(1).IsRequired());
            Value(x => x.PatientConditionDescription1, 10, x => x.MinLength(1).MaxLength(80));
            Value(x => x.PatientConditionDescription2, 11, x => x.MinLength(1).MaxLength(80));
            Value(x => x.XrayAvailable, 12, x => x.FixedLength(1));
        }
    }
}