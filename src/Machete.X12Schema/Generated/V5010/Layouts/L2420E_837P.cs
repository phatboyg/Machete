namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2420E_837P :
        X12Layout
    {
        Segment<NM1> Name { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
        
        Segment<PER> ContactInfo { get; }
    }
}