namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAMT_2_860 :
        X12Layout
    {
        Segment<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
    }
}