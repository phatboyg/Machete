namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_3_850 :
        X12Layout
    {
        Segment<N1> Name { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> AddressInformation { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<NX2> LocationIdComponent { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        Segment<SCH> LineItemSchedule { get; }
        
        SegmentList<TD1> CarrierDetailsQuantityAndWeight { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<TD3> CarrierDetailsEquipment { get; }
        
        SegmentList<TD4> CarrierDetailsSpecialHandlingOrHazardousMaterial { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        LayoutList<LoopLDT_2_850> LoopLDT { get; }
    }
}