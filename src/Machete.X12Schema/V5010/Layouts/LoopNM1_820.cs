namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopNM1_820 :
        X12Layout
    {
        Segment<NM1> IndividualOrOrganizationName { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> AddressInformation { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
    }
}