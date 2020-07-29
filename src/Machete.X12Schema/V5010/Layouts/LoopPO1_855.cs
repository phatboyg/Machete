namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPO1_855 :
        X12Layout
    {
        Segment<PO1> BaselineItemData { get; }
        
        SegmentList<LIN> ItemIdentification { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        Segment<CUR> Currency { get; }
        
        SegmentList<PO3> AdditionalItemDetail { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        LayoutList<LoopPID_855> LoopPID { get; }
        
        SegmentList<PWK> Paperwork { get; }
        
        SegmentList<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopSAC_855> LoopSAC { get; }
        
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
        
        LayoutList<LoopACK_855> LoopACK { get; }
        
        SegmentList<MAN> MarksAndNumbersInformation { get; }
        
        SegmentList<AMT> MonetaryAmountInformation { get; }
        
        SegmentList<CTB> RestrictionsOrConditions { get; }
        
        SegmentList<TXI> TaxInformation { get; }
        
        LayoutList<LoopQTY_855> LoopQTY { get; }
        
        LayoutList<LoopPKG_855> LoopPKG { get; }
        
        LayoutList<LoopSCH_855> LoopSCH { get; }
        
        LayoutList<LoopN9_855> LoopN9 { get; }
        
        LayoutList<LoopN1_2_855> LoopN1 { get; }
        
        LayoutList<LoopSLN_855> LoopSLN { get; }
    }
}