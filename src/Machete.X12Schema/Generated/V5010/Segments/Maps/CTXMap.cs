namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class CTXMap :
        X12SegmentMap<CTX, X12Entity>
    {
        public CTXMap()
        {
            Id = "CTX";
            Name = "Segment Context";

            Value(x => x.ContextIdentificat, 1);
            Value(x => x.SegmentIDCode, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.SegmentPosInTS, 3, x => x.MinLength(1).MaxLength(10));
            Value(x => x.LoopIDCode, 4, x => x.MinLength(1).MaxLength(4));
            Value(x => x.PositionInSegment, 5);
            Value(x => x.ReferenceInSegment, 6);
        }
    }
}
