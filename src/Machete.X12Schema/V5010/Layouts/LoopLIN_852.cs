namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLIN_852 : 
        X12Layout
    {
        Segment<LIN> ItemIdentification { get; }
        
        SegmentList<CTP> PricingInformation { get;  }
        
        SegmentList<SAC> ServiceAllowanceOrChargeInformation { get; }
        
        Segment<PO4> ItemPhysicalDetails { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<AMT> MonetaryAmountInformation { get; }
        
        Segment<PAL> PalletTypeAndLoadCharacteristics { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        LayoutList<LoopZA_852> LoopZA { get; }
    }
}