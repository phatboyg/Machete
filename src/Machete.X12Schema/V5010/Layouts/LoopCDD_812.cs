namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopCDD_812 :
        X12Layout
    {
        Segment<CDD> Name { get; }
        
        Segment<LIN> ItemIdentification { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        SegmentList<N9> ReferenceIdentification { get; }
        
        Segment<DTM> DateTimeReference { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
    }
}