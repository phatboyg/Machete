namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopZA_852 : 
        X12Layout
    {
        Segment<ZA> ProductActivityReporting { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        SegmentList<CTP> PricingInformation { get;  }
        
        Segment<SDQ> DestinationQuantity { get; }
        
        LayoutList<LoopG95_852> LoopG95 { get;  }
    }
}