namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPOC_865 :
        X12Layout
    {
        Segment<POC> LineItemChange { get; }
        
        SegmentList<LIN> ItemIdentification { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<CUR> Currency { get; }
        
        SegmentList<PO3> AdditionalItemInformation { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        LayoutList<LoopPID_865> LoopPID { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        SegmentList<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopSAC_865> LoopSAC { get; }
        
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
        
        SegmentList<TXI> TaxInformation { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
        
        LayoutList<LoopACK_865> LoopACK { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        Segment<SPI> SpecificationIdentifier { get; }
        
        SegmentList<MTX> Text { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        LayoutList<LoopLM_865> LoopLM { get; }
        
        LayoutList<LoopAMT_865> LoopAMT { get; }
        
        LayoutList<LoopQTY_865> LoopQTY { get; }
        
        LayoutList<LoopSCH_865> LoopSCH { get; }
        
        LayoutList<LoopLDT_3_865> LoopLDT { get; }
        
        LayoutList<LoopN9_1_865> LoopN9 { get; }
        
        LayoutList<LoopN1_2_865> LoopN1 { get; }
        
        LayoutList<LoopSLN_865> LoopSLN { get; }
        
        LayoutList<LoopPD_865> LoopPD { get; }
    }
}