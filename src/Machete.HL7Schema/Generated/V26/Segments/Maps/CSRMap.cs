// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSR (SegmentMap) - Clinical Study Registration
    /// </summary>
    public class CSRMap :
        HL7V26SegmentMap<CSR>
    {
        public CSRMap()
        {
            Id = "CSR";

            Name = "Clinical Study Registration";

            Entity(x => x.SponsorStudyId, 1, x => x.IsRequired());
            Entity(x => x.AlternateStudyId, 2);
            Entity(x => x.InstitutionRegisteringPatient, 3);
            Entity(x => x.SponsorPatientId, 4, x => x.IsRequired());
            Entity(x => x.AlternatePatientId, 5);
            Value(x => x.DateTimeOfPatientStudyRegistration, 6, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.PersonPerformingStudyRegistration, 7);
            Entity(x => x.StudyAuthorizingProvider, 8, x => x.IsRequired());
            Value(x => x.DateTimePatientStudyConsentSigned, 9, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.PatientStudyEligibilityStatus, 10);
            Value(x => x.StudyRandomizationDateTime, 11, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.RandomizedStudyArm, 12);
            Entity(x => x.StratumForStudyRandomization, 13);
            Entity(x => x.PatientEvaluabilityStatus, 14);
            Value(x => x.DateTimeEndedStudy, 15, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ReasonEndedStudy, 16);
        }
    }
}