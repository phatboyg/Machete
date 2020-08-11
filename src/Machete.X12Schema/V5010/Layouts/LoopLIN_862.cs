namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLIN_862 : 
        X12Layout
    {
        Segment<LIN> ItemIdentification { get; }
        
        Segment<UIT> UnitDetail { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        Segment<PRS> PartReleaseStatus { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        Segment<SDP> ShipOrDeliveryPattern { get; }
        
        LayoutList<LoopFST_862> LoopFST { get; }
        
        LayoutList<LoopSHP_862> LoopSHP { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
    }
}