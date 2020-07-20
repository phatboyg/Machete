namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2420D_837D :
        X12Layout
    {
        Segment<NM1> ServiceFacilityLocation { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}