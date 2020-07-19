namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopIT1 :
        X12Layout
    {
        Segment<IT1> BaselineItemData { get; }
        
        Segment<CRC> ConditionsIndicator { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        Segment<CUR> Currency { get; }
        
        Segment<IT3> AdditionalItemData { get; }
        
        Segment<TXI> TaxInformation { get; }
        
        Segment<CTP> PricingInformation { get; }
        
        Segment<PAM> PeriodAmount { get; }
        
        Segment<MEA> Measurements { get; }
        
        LayoutList<LoopPID> LoopPID { get; }
        
        Segment<PWK> Paperwork { get; }
        
        Segment<PKG> MarkingPackagingOrLoadingRequirements { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        Segment<ITD> TermsOfSale { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        Segment<YNQ> YesNoQuestion { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        Segment<SDQ> DestinationQuantity { get; }
        
        Segment<DTM> DateTimeReference { get; }
        
        Segment<CAD> CarrierDetails { get; }
        
        Segment<L7> TariffReference { get; }
        
        Segment<SR> RequestedServiceSchedule { get; }
        
        LayoutList<LoopSAC> LoopSAC { get; }
        
        LayoutList<LoopSLN> LoopSLN { get; }
        
        LayoutList<LoopN1> LoopN1 { get; }
        
        LayoutList<LoopLM> LoopLM { get; }
        
        LayoutList<LoopV1> LoopV1 { get; }
        
        Layout<LoopFA1> LoopFA1 { get; }
    }
}