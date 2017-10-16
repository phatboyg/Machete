namespace Machete.X12.Schema.Segments.Maps
{
    using Configuration;


    public class SEMap :
        X12SegmentMap<SE, X12Entity>
    {
        public SEMap()
        {
            Id = "SE";

            Name = "Transaction Set Trailer";

            Value(x => x.SegmentCount, 1, x => x.IsRequired().MinLength(1).MaxLength(10));
            Value(x => x.ControlNumber, 2, x => x.IsRequired().MinLength(4).MaxLength(9));
        }
    }
}