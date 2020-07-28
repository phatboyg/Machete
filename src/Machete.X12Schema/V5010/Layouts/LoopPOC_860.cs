namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPOC_860 :
        X12Layout
    {
        Segment<POC> LineItemChange { get; }
        
        SegmentList<LIN> ItemIdentification { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<CUR> Currency { get; }
        
        SegmentList<CN1> ContractInformation { get; }
        
        SegmentList<PO3> AdditionalItemInformation { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        LayoutList<LoopPID_860> LoopPID { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        SegmentList<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopSAC_860> LoopSAC { get; }
        
        Segment<IT8> ConditionsOfSale { get; }
        
        SegmentList<CSH> SalesRequirements { get; }
        
        SegmentList<ITD> TermsOfSale { get; }
        
        SegmentList<DIS> DiscountDetail { get; }
        
        Segment<INC> InstallmentInformation { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        SegmentList<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<SDQ> DestinationQuantity { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
        
        SegmentList<TC2> Commodity { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        SegmentList<TXI> TaxInformation { get; }
        
        Segment<SPI> SpecificationIdentifier { get; }
        
        SegmentList<MTX> Text { get; }
        
        LayoutList<LoopQTY_860> LoopQTY { get; }
        
        LayoutList<LoopSCH_860> LoopSCH { get; }
        
        LayoutList<LoopN9_1_860> LoopN9 { get; }
        
        Segment<LS> LoopHeader { get; }
        
        LayoutList<LoopSLN_860> LoopSLN { get; }
        
        LayoutList<LoopAMT_2_860> LoopAMT { get; }
        
        LayoutList<LoopLM_860> LoopLM { get; }
    }
}