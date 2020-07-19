namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class IK5Map :
        X12SegmentMap<IK5, X12Entity>
    {
        public IK5Map()
        {
            Id = "IK5";
            Name = "Transaction Set Response Trailer";

            Value(x => x.TSAckCode, 1, x => x.IsRequired());
            Value(x => x.ImpleTSSynErCode1, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ImpleTSSynErCode2, 3, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ImpleTSSynErCode3, 4, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ImpleTSSynErCode4, 5, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ImpleTSSynErCode5, 6, x => x.MinLength(1).MaxLength(3));
        }
    }
}