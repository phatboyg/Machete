namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_1_812 :
        X12Layout
    {
        Segment<N1> Name { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> AddressInformation { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<N9> ReferenceIdentification { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        LayoutList<LoopLM> LoopLM { get; }
        
        LayoutList<LoopN11> LoopN11 { get; }
    }
}