namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;


    public class IK4Map :
        X12SegmentMap<IK4, X12Entity>
    {
        public IK4Map()
        {
            Id = "IK4";
            Name = "Implementation Data Element Note";

            Value(x => x.PositionInSegment, 1);
            Value(x => x.DataElementRefNumber, 2, x => x.MinLength(1).MaxLength(4));
            Value(x => x.ImpleDataSynErCode, 3, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CopyOfBadDataElement, 4, x => x.MinLength(1).MaxLength(99));
        }
    }
}