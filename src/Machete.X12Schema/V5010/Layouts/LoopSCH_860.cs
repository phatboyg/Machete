namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopSCH_860 :
        X12Layout
    {
        Segment<SCH> LineItemSchedule { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
    }
}