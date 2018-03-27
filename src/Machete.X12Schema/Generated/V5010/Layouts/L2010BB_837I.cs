namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2010BB_837I :
        X12Layout
    {
        Segment<NM1> Payer { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
        
        Segment<REF> BillingProviderSecondaryIdentification { get; }
    }
}