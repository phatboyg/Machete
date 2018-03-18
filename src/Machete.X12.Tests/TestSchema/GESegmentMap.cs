namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class GESegmentMap :
        X12SegmentMap<GESegment, X12Entity>
    {
        public GESegmentMap()
        {
            Id = "GE";
            Name = "Functional Group Trailer";

            Value(x => x.TransactionSetCount, 1, x => x.IsRequired().MinLength(1).MaxLength(6));
            Value(x => x.ControlNumber, 2, x => x.IsRequired().MinLength(1).MaxLength(9));
        }
    }
}