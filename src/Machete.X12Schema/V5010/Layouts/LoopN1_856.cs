namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_856 :
        X12Layout
    {
        Segment<N1> Name { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> AddressInformation { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        Segment<FOB> FreeOnBoardRelatedInstructions { get; }
    }
}