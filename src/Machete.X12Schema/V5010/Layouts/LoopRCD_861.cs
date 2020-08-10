namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopRCD_861 :
        X12Layout
    {
        Segment<RCD> ReceivingConditions { get; }
        
        Segment<SN1> ItemDetail { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<LIN> ItemIdentification { get; }
        
        SegmentList<PID> ItemDescription { get; }
        
        SegmentList<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<PRF> PurchaseOrderReference { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        Segment<MAN> MarksAndNumbersInformation { get; }
        
        LayoutList<LoopLM_861> LoopLM { get; }
        
        LayoutList<LoopSLN_861> LoopSLN { get; }
        
        LayoutList<LoopN1_861> LoopN1 { get; }
        
        LayoutList<LoopFA1_861> LoopFA1 { get; }
    }
}