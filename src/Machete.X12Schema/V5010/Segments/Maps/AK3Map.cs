namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AK3Map :
        X12SegmentMap<AK3, X12Entity>
    {
        public AK3Map()
        {
            Id = "AK3";
            Name = "Error Identification";

            Value(x => x.SegmentIdCode, 1, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.SegmentPositionInTransactionSet, 2, x => x.MinLength(1).MaxLength(10).IsRequired());
            Value(x => x.LoopIdentifierCode, 3, x => x.MinLength(1).MaxLength(4));
            Value(x => x.SegmentSyntaxErrorCode, 4, x => x.MinLength(1).MaxLength(3).IsRequired());
        }
    }
}