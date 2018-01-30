namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class CRCMap :
        X12SegmentMap<CRC, X12Entity>
    {
        public CRCMap()
        {
            Id = "CRC";
            Name = "Conditions Indicator";
            
            Value(x => x.CodeCategory, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.CertificationConditionIndicator, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.ConditionCode1, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.ConditionCode2, 4, x => x.FixedLength(2));
            Value(x => x.ConditionCode3, 5, x => x.FixedLength(2));
            Value(x => x.ConditionCode4, 6, x => x.FixedLength(2));
            Value(x => x.ConditionCode5, 7, x => x.FixedLength(2));
        }
    }
}