// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// CSR (Segment) - Clinical Study Registration
    /// </summary>
    public interface CSR :
        HL7V26Segment
    {
        /// <summary>
        /// CSR-1: Sponsor Study ID
        /// </summary>
        Value<EI> SponsorStudyId { get; }

        /// <summary>
        /// CSR-2: Alternate Study ID
        /// </summary>
        Value<EI> AlternateStudyId { get; }

        /// <summary>
        /// CSR-3: Institution Registering the Patient
        /// </summary>
        Value<CWE> InstitutionRegisteringPatient { get; }

        /// <summary>
        /// CSR-4: Sponsor Patient ID
        /// </summary>
        Value<CX> SponsorPatientId { get; }

        /// <summary>
        /// CSR-5: Alternate Patient ID - CSR
        /// </summary>
        Value<CX> AlternatePatientId { get; }

        /// <summary>
        /// CSR-6: Date/Time of Patient Study Registration
        /// </summary>
        Value<DateTimeOffset> DateTimeOfPatientStudyRegistration { get; }

        /// <summary>
        /// CSR-7: Person Performing Study Registration
        /// </summary>
        ValueList<XCN> PersonPerformingStudyRegistration { get; }

        /// <summary>
        /// CSR-8: Study Authorizing Provider
        /// </summary>
        ValueList<XCN> StudyAuthorizingProvider { get; }

        /// <summary>
        /// CSR-9: Date/time Patient Study Consent Signed
        /// </summary>
        Value<DateTimeOffset> DateTimePatientStudyConsentSigned { get; }

        /// <summary>
        /// CSR-10: Patient Study Eligibility Status
        /// </summary>
        Value<CWE> PatientStudyEligibilityStatus { get; }

        /// <summary>
        /// CSR-11: Study Randomization Date/time
        /// </summary>
        Value<DateTimeOffset> StudyRandomizationDateTime { get; }

        /// <summary>
        /// CSR-12: Randomized Study Arm
        /// </summary>
        Value<CWE> RandomizedStudyArm { get; }

        /// <summary>
        /// CSR-13: Stratum for Study Randomization
        /// </summary>
        Value<CWE> StratumForStudyRandomization { get; }

        /// <summary>
        /// CSR-14: Patient Evaluability Status
        /// </summary>
        Value<CWE> PatientEvaluabilityStatus { get; }

        /// <summary>
        /// CSR-15: Date/time Ended Study
        /// </summary>
        Value<DateTimeOffset> DateTimeEndedStudy { get; }

        /// <summary>
        /// CSR-16: Reason Ended Study
        /// </summary>
        Value<CWE> ReasonEndedStudy { get; }
    }
}