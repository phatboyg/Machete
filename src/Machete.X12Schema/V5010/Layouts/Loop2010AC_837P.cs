namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2010AC_837P :
        X12Layout
    {
        Segment<NM1> PayToPlanName { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<REF> SecondaryIdentification { get; }
        
        Segment<REF> TaxIdNumber { get; }
    }
}