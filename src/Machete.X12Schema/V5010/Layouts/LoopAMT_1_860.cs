namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopAMT_1_860 :
        X12Layout
    {
        Segment<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
        
        LayoutList<LoopFA1_860> LoopFA1 { get; }
    }
}