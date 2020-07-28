namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T860 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BCH> BeginningPurchaseOrderChange { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<CSH> SalesRequirements { get; }
        
        LayoutList<LoopSAC_860> LoopSAC { get; }
        
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
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<G53> MaintenanceType { get; }
        
        SegmentList<TXI> TaxInformation { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
        
        LayoutList<LoopLDT_1_860> LoopLDT { get; }
        
        LayoutList<LoopAMT_1_860> LoopAMT { get; }
        
        LayoutList<LoopN9_1_860> LoopN9 { get; }
        
        LayoutList<LoopN1_1_860> LoopN1 { get; }
        
        LayoutList<LoopLM_860> LoopLM { get; }
        
        LayoutList<LoopSPI_860> LoopSPI { get; }
        
        LayoutList<LoopADV_860> LoopADV { get; }
        
        LayoutList<LoopPOC_860> LoopPOC { get; }
        
        Layout<LoopCTT_850> LoopCTT { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}