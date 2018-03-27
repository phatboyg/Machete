namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2420C_837P :
        X12Layout
    {
        Segment<NM1> LocationName { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInfo { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}