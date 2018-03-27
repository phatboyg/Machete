namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2010AB_837D :
        X12Layout
    {
        Segment<NM1> AddressName { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
    }
}