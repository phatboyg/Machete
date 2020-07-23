namespace Machete.X12Schema.V5010
{
    using Segments;
    using X12;


    public interface LoopDAD_812 :
        X12Layout
    {
        Segment<DAD> DebitAuthorizationDetail { get; }
        
        Segment<NM1> IndividualOrOrganizationName { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> AddressInformation { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
    }
}