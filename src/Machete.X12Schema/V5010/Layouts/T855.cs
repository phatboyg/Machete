namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T855 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BAK> BeginningPurchaseOrderAcknowledgement { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<CSH> SalesRequirements { get; }
        
        LayoutList<LoopSAC_855> LoopSAC { get; }
        
        SegmentList<ITD> TermsOfSale { get; }
        
        SegmentList<DIS> DiscountDetail { get; }
        
        Segment<INC> InstallmentInformation { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        Segment<LDT> LeadTime { get; }
        
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
        
        SegmentList<TXI> TaxInformation { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        LayoutList<LoopN9_1_855> LoopN9 { get; }
        
        LayoutList<LoopN1_1_855> LoopN1 { get; }
        
        LayoutList<LoopADV_855> LoopADV { get; }
        
        LayoutList<LoopPO1_855> LoopPO1 { get; }
        
        Layout<LoopCTT_850> LoopCTT { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}