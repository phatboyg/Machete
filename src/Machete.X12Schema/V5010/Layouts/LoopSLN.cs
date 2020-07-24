namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        SegmentList<TC2> Commodity { get; }
        
        SegmentList<TXI> TaxInformation { get; }
    }
}