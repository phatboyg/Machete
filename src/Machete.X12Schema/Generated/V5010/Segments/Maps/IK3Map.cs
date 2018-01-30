namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class IK3Map :
        X12SegmentMap<IK3, X12Entity>
    {
        public IK3Map()
        {
            Id = "IK3";
            Name = "Error Identification";

            Value(x => x.SegmentIDCode, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.SegmentPosInTS, 2, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.LoopIDCode, 3, x => x.MinLength(1).MaxLength(4));
            Value(x => x.ImpleSegSynErCode, 4, x => x.MinLength(1).MaxLength(3).IsRequired());
        }
    }
}