namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_2_850 :
        X12Layout
    {
        Segment<N1> Name { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> AddressInformation { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<G61> Contact { get; }
        
        SegmentList<MSG> MessageText { get; }
    }
}