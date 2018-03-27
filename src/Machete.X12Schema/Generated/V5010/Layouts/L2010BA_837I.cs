namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2010BA_837I :
        X12Layout
    {
        Segment<NM1> Subscriber { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<DMG> DemographicInformation { get; }
        
        Segment<REF> SecondaryIdentification { get; }
        
        Segment<REF> PropertyAndCasualtyClaimNumber { get; }
    }
}