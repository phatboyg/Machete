namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_852 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
        
        SegmentList<TD5> CarrierDetailsRoutingSequenceOrTransitTime { get; }
        
        SegmentList<DTM> DateOrTimeReference { get;  }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
    }
}