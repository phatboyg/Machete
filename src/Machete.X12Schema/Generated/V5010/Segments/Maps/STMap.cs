namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


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