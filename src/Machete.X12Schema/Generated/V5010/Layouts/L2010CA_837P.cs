namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2010CA_837P :
        X12Layout
    {
        Segment<NM1> Name { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<DMG> DemographicInformation { get; }
        
        Segment<REF> PropertyAndCasualtyClaimNumber { get; }
        
        Segment<REF> PropertyAndCasualtyPatientIdentifier { get; }
        
        Segment<PER> PropertyAndCasualtyPatientContactInformation { get; }
    }
}