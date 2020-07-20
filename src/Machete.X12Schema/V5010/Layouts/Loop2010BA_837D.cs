namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2010BA_837D :
        X12Layout
    {
        Segment<NM1> SubscriberName { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<DMG> DemographicInformation { get; }
        
        Segment<REF> SecondaryIdentification { get; }
        
        Segment<REF> PropertyAndCasualtyClaimNumber { get; }
    }
}