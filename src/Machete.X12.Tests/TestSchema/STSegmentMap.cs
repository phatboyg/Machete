namespace Machete.X12.Tests.TestSchema
{
    using Configuration;


    public class STSegmentMap :
        X12SegmentMap<STSegment, X12Entity>
    {
        public STSegmentMap()
        {
            Id = "ST";
            Name = "Transaction Set";

            Value(x => x.IdentifierCode, 1, x => x.IsRequired().FixedLength(3));
            Value(x => x.ControlNumber, 2, x => x.IsRequired().MinLength(4).MaxLength(9));
        }
    }
}