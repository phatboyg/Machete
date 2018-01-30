namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Schema.Segments;


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