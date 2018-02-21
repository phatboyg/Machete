namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2310E_837I :
        X12Layout
    {
        Segment<NM1> FacilityLocation { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}