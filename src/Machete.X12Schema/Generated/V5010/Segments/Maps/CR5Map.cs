namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CR5Map :
        X12SegmentMap<CR5, X12Entity>
    {
        public CR5Map()
        {
            Id = "CR5";
            Name = "Oxygen Therapy Certification";
            
            Value(x => x.CertificationTypeCode, 1, x => x.FixedLength(1).IsRequired());
            Value(x => x.TreatmentPeriodCount, 2, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.ArterialBloodGasQuantity, 10, x => x.MinLength(1).MaxLength(15));
            Value(x => x.OxygenSaturationQuantity, 11, x => x.MinLength(1).MaxLength(15));
            Value(x => x.OxygenTestConditionCode, 12, x => x.FixedLength(1).IsRequired());
            Value(x => x.OxygenTestFindingsCode, 13, x => x.FixedLength(1));
            Value(x => x.OxygenTestFindingsCode2, 14, x => x.FixedLength(1));
            Value(x => x.OxygenTestFindingsCode3, 15, x => x.FixedLength(1));
        }
    }
}