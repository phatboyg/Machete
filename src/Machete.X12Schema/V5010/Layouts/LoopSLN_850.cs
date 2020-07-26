namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_850 :
        X12Layout
    {
        Segment<SLN> SublineItemDetail { get; }
        
        SegmentList<MSG> MessageText { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<PID> ProductOrITemDescription { get; }
        
        SegmentList<PO3> AdditionalItemDetail { get; }
        
        SegmentList<TC2> Commodity { get; }
        
        SegmentList<ADV> AdvertisingDemographicInformation { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
        
        SegmentList<CTP> PricingInformation { get; }
        
        SegmentList<PAM> PeriodAmount { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        LayoutList<LoopN9_850> LoopN9 { get; }
        
        LayoutList<LoopSAC_2_850> LoopSAC { get; }
        
        LayoutList<LoopQTY_850> LoopQTY { get; }
        
        LayoutList<LoopN1_4_850> LoopN1 { get; }
    }
}