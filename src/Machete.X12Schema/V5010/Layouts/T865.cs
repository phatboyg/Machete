namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T865 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BCA> BeginningPurchaseOrderChange { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<CSH> SalesRequirements { get; }
        
        LayoutList<LoopSAC_865> LoopSAC { get; }
        
        SegmentList<ITD> TermsOfSale { get; }
        
        SegmentList<DIS> DiscountDetail { get; }
        
        Segment<INC> InstallmentInformation { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        Segment<LIN> ItemIdentification { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<TXI> TaxInformation { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        SegmentList<G53> MaintenanceType { get; }
        
        LayoutList<LoopLDT_1_865> LoopLDT { get; }
        
        LayoutList<LoopN9_1_865> LoopN9 { get; }
        
        LayoutList<LoopN1_1_865> LoopN1 { get; }
        
        LayoutList<LoopAMT_865> LoopAMT { get; }
        
        LayoutList<LoopADV_865> LoopADV { get; }
        
        LayoutList<LoopLM_865> LoopLM { get; }
        
        LayoutList<LoopPOC_865> LoopPOC { get; }
        
        Layout<LoopCTT_865> LoopCTT { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}