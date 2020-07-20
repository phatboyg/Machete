namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2010AA_837D :
        X12Layout
    {
        Segment<NM1> BillingProvider { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<REF> TaxIdNumber { get; }
        
        SegmentList<REF> UPINOrLicenseInformation { get; }
        
        SegmentList<PER> ContactInformation { get; }
    }
}