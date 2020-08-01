namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_865 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        SegmentList<MTX> Text { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<PID> ProductOrITemDescription { get; }
        
        SegmentList<PO3> AdditionalItemDetail { get; }
        
        SegmentList<MEA> Measurements { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        SegmentList<ACK> LineItemAcknowledgement { get; }
        
        LayoutList<LoopSAC_865> LoopSAC { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        SegmentList<ADV> AdvertisingDemographicInformation { get; }
        
        LayoutList<LoopQTY_865> LoopQTY { get; }
        
        LayoutList<LoopN9_2_865> LoopN9 { get; }
        
        LayoutList<LoopN1_3_865> LoopN1 { get; }
    }
}