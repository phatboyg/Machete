namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class SESegmentMap :
        X12SegmentMap<SESegment, X12Entity>
    {
        public SESegmentMap()
        {
            Id = "SE";
            Name = "Transaction Set Trailer";

            Value(x => x.SegmentCount, 1, x => x.IsRequired().MinLength(1).MaxLength(10));
            Value(x => x.ControlNumber, 2, x => x.IsRequired().MinLength(4).MaxLength(9));
        }
    }
}