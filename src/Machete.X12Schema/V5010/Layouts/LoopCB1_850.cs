namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopCB1_850 :
        X12Layout
    {
        Segment<CB1> ContractAndCostAccountingStandardsData { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<LDT> LeadTime { get; }
        
        SegmentList<MTX> Text { get; }
    }
}