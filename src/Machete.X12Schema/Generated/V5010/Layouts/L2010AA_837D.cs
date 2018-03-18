namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2010AA_837D :
        X12Layout
    {
        Segment<NM1> BillingProvider { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<REF> TaxIdNumber { get; }
        
        Segment<REF> UPINOrLicenseInformation { get; }
        
        SegmentList<PER> ContactInformation { get; }
    }
}