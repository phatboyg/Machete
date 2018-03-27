namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2010AC_837P :
        X12Layout
    {
        Segment<NM1> Plan { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<REF> SecondaryIdentification { get; }
        
        Segment<REF> TaxIdNumber { get; }
    }
}