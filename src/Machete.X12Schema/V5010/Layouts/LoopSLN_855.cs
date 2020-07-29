namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSLN_855 :
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
        
        LayoutList<LoopSAC_855> LoopSAC { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<TAX> TaxReference { get; }
        
        SegmentList<ADV> AdvertisingDemographicInformation { get; }
        
        LayoutList<LoopQTY_855> LoopQTY { get; }
        
        LayoutList<LoopN9_2_855> LoopN9 { get; }
        
        LayoutList<LoopN1_4_860> LoopN1 { get; }
    }
}