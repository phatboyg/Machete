namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class GEMap :
        X12SegmentMap<GE, X12Entity>
    {
        public GEMap()
        {
            Id = "GE";
            Name = "Functional Group Trailer";

            Value(x => x.TransactionSetCount, 1, x => x.IsRequired().MinLength(1).MaxLength(6));
            Value(x => x.ControlNumber, 2, x => x.IsRequired().MinLength(1).MaxLength(9));
        }
    }
}