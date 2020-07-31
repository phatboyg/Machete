namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopISR_2_870 :
        X12Layout
    {
        Segment<ISR> ItemStatusReport { get; }
        
        SegmentList<PID> ProductOrItemDescription { get; }
        
        Segment<QTY> QuantityInformation { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        Segment<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<SAC> ServicePromotionAllowanceOrChargeInformation { get; }
        
        LayoutList<LoopLM_870> LoopLM { get; }
    }
}