namespace Machete.X12Schema.V5010.Segments.Maps
{
    using X12;
    using X12.Configuration;

    
    public class AK9Map :
        X12SegmentMap<AK9, X12Entity>
    {
        public AK9Map()
        {
            Id = "AK9";
            Name = "Functional Group Response Trailer";

            Value(x => x.FunctGroupAckCode, 1, x => x.MinLength(1).MaxLength(1).IsRequired());
            Value(x => x.NumberOfTSIncluded, 2, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.NumberOfReceivedTS, 3, x => x.MinLength(1).MaxLength(6));
            Value(x => x.NumberOfAcceptedTS, 4, x => x.MinLength(1).MaxLength(6));
            Value(x => x.FunctGroupErrorCode1, 5, x => x.MinLength(1).MaxLength(3));
            Value(x => x.FunctGroupErrorCode2, 6, x => x.MinLength(1).MaxLength(3));
            Value(x => x.FunctGroupErrorCode3, 7, x => x.MinLength(1).MaxLength(3));
            Value(x => x.FunctGroupErrorCode4, 8, x => x.MinLength(1).MaxLength(3));
            Value(x => x.FunctGroupErrorCode5, 9, x => x.MinLength(1).MaxLength(3));
        }
    }
}
