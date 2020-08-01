namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAMT_865 :
        X12Layout
    {
        Segment<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
    }
}