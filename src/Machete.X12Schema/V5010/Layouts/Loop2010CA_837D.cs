namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2010CA_837D :
        X12Layout
    {
        Segment<NM1> PatientName { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        Segment<DMG> DemographicInformation { get; }
        
        Segment<REF> PropertyAndCasualtyClaimNumber { get; }
        
        Segment<REF> PropertyAndCasualtyPatientIdentifier { get; }
    }
}