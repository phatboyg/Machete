namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_860 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        SegmentList<MTX> Text { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<PID> ProductOrITemDescription { get; }
        
        SegmentList<PO3> AdditionalItemDetail { get; }
        
        SegmentList<TC2> Commodity { get; }
        
        LayoutList<LoopSAC_2_850> LoopSAC { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        SegmentList<ADV> AdvertisingDemographicInformation { get; }
        
        LayoutList<LoopQTY_850> LoopQTY { get; }
        
        LayoutList<LoopN9_2_860> LoopN9 { get; }
        
        LayoutList<LoopN1_4_860> LoopN1 { get; }
    }
}