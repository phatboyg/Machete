namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPO1_850 :
        X12Layout
    {
        Segment<PO1> BaselineItemData { get; }
        
        SegmentList<LIN> ItemIdentification { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        Segment<CUR> Currency { get; }
        
        Segment<CN1> ContractInformation { get; }
        
        SegmentList<PO3> AdditionalItemDetail { get; }
        
        LayoutList<LoopCTP_850> LoopCTP { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        LayoutList<LoopPID_850> LoopPID { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopSAC_2_850> LoopSAC { get; }
        
        Segment<IT8> ConditionsOfSale { get; }
        
        SegmentList<CSH> SalesRequirements { get; }
        
        SegmentList<ITD> TermsOfSale { get; }
        
        SegmentList<DIS> DiscountDetail { get; }
        
        Segment<INC> InstallmentInformation { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        SegmentList<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<SDQ> DestinationQuantity { get; }
        
        SegmentList<IT3x> AdditionalItemData { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<TC2> Commodity { get; }
        
        Segment<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<PCT> PercentAmounts { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<MTX> Text { get; }
        
        Segment<SPI> SpecificationIdentifier { get; }
        
        SegmentList<TXI> TaxInformation { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        LayoutList<LoopQTY_850> LoopQTY { get; }
        
        LayoutList<LoopSCH_850> LoopSCH { get; }
        
        LayoutList<LoopPKG_850> LoopPKG { get; }
        
        SegmentList<LS> LoopHeader { get; }
        
        LayoutList<LoopLDT_3_850> LoopLDT { get; }
        
        LayoutList<LoopN9_850> LoopN9 { get; }
        
        LayoutList<LoopN1_3_850> LoopN1 { get; }
        
        LayoutList<LoopSLN_850> LoopSLN { get; }
        
        LayoutList<LoopAMT_850> LoopAMT { get; }
        
        LayoutList<LoopLM_850> LoopLM { get; }
    }
}