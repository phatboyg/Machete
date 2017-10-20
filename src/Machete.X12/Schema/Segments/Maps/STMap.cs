namespace Machete.X12.Schema.Segments.Maps
{
    using Configuration;


    public class STMap :
        X12SegmentMap<ST, X12Entity>
    {
        public STMap()
        {
            Id = "ST";

            Name = "Transaction Set";

            Value(x => x.IdentifierCode, 1, x => x.IsRequired().FixedLength(3));
            Value(x => x.ControlNumber, 2, x => x.IsRequired().MinLength(4).MaxLength(9));
        }
    }
}