namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T861 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BRA> BeginningReceivingAdviceOrAcceptanceCertificate { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<PRF> PurchaseOrderReference { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        LayoutList<LoopN1_861> LoopN1 { get; }
        
        LayoutList<LoopLM_861> LoopLM { get; }
        
        LayoutList<LoopFA1_861> LoopFA1 { get; }
        
        LayoutList<LoopRCD_861> LoopRCD { get; }
        
        Segment<CTT> TransactionTotals { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}