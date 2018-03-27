namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AK2Map :
        X12SegmentMap<AK2, X12Entity>
    {
        public AK2Map()
        {
            Id = "AK2";
            Name = "Transaction Set Response Header";

            Value(x => x.IdCode, 1, x => x.MinLength(3).MaxLength(3).IsRequired());
            Value(x => x.ControlNumber, 2, x => x.MinLength(4).MaxLength(9).IsRequired());
            Value(x => x.ImpleConvReference, 3, x => x.MinLength(1).MaxLength(35));
        }
    }
}