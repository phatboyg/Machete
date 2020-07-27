namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T850 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BEG> BeginningPurchaseOrder { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<CSH> SalesRequirements { get; }
        
        SegmentList<TC2> Commodity { get; }
        
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
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        SegmentList<TXI> TaxInformation { get; }
        
        LayoutList<LoopLDT_1_850> LoopLDT { get; }
        
        LayoutList<LoopAMT_850> LoopAMT { get; }
        
        LayoutList<LoopN9_850> LoopN9 { get; }
        
        LayoutList<LoopN1_1_850> LoopN1 { get; }
        
        LayoutList<LoopLM_850> LoopLM { get; }
        
        LayoutList<LoopSPI_850> LoopSPI { get; }
        
        LayoutList<LoopADV_850> LoopADV { get; }
        
        LayoutList<LoopPO1_850> LoopPO1 { get; }
        
        Layout<LoopCTT_850> LoopCTT { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}