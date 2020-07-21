namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop1000A_835 :
        X12Layout
    {
        Segment<N1> PayerIdentification { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> AdditionalIdentification { get; }
        
        Segment<PER> BusinessContactInformation { get; }
        
        SegmentList<PER> TechnicalContactInformation { get; }
        
        Segment<PER> PayerWebsite { get; }
    }
}