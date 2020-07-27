namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopHL_856 :
        X12Layout
    {
        Segment<HL> HierarchicalLevel { get; }
        
        Segment<LIN> ItemIdentification { get; }
        
        Segment<SN1> ItemDetail { get; }
        
        SegmentList<SLN> SublineItemDetail { get; }
        
        Segment<PRF> PurchaseOrderReference { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        Segment<TSD> TrailerShipmentDetails { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopLH1_856> LoopLH1 { get; }
        
        LayoutList<LoopCLD_856> LoopCLD { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        Segment<PAL> PalletInformation { get; }
        
        LayoutList<LoopN1_856> LoopN1 { get; }
        
        SegmentList<SDQ> DestinationQuantity { get; }
        
        Segment<ETD> ExcessTransportationDetail { get; }
        
        Segment<CUR> Currency { get; }
        
        LayoutList<LoopSAC_856> LoopSAC { get; }
        
        SegmentList<GF> FurnishedGoodsAndServices { get; }
        
        SegmentList<YNQ> YesOrNoQuestion { get; }
        
        LayoutList<LoopLM_856> LoopLM { get; }
        
        LayoutList<LoopV1_856> LoopV1 { get; }
    }
}