namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2310E_837P :
        X12Layout
    {
        Segment<NM1> PickUpLocation { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
    }
}