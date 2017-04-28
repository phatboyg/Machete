// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;

    /// <summary>
    /// PEO (Segment) - Product Experience Observation
    /// </summary>
    public interface PEO :
        HL7Segment
    {
        /// <summary>
        /// PEO-1: Event Identifiers Used
        /// </summary>
        ValueList<CWE> EventIdentifiersUsed { get; }

        /// <summary>
        /// PEO-2: Event Symptom/Diagnosis Code
        /// </summary>
        ValueList<CWE> EventSymptomDiagnosisCode { get; }

        /// <summary>
        /// PEO-3: Event Onset Date/Time
        /// </summary>
        Value<DateTimeOffset> EventOnsetDateTime { get; }

        /// <summary>
        /// PEO-4: Event Exacerbation Date/Time
        /// </summary>
        Value<DateTimeOffset> EventExacerbationDateTime { get; }

        /// <summary>
        /// PEO-5: Event Improved Date/Time
        /// </summary>
        Value<DateTimeOffset> EventImprovedDateTime { get; }

        /// <summary>
        /// PEO-6: Event Ended Data/Time
        /// </summary>
        Value<DateTimeOffset> EventEndedDataTime { get; }

        /// <summary>
        /// PEO-7: Event Location Occurred Address
        /// </summary>
        ValueList<XAD> EventLocationOccurredAddress { get; }

        /// <summary>
        /// PEO-8: Event Qualification
        /// </summary>
        ValueList<string> EventQualification { get; }

        /// <summary>
        /// PEO-9: Event Serious
        /// </summary>
        Value<string> EventSerious { get; }

        /// <summary>
        /// PEO-10: Event Expected
        /// </summary>
        Value<string> EventExpected { get; }

        /// <summary>
        /// PEO-11: Event Outcome
        /// </summary>
        ValueList<string> EventOutcome { get; }

        /// <summary>
        /// PEO-12: Patient Outcome
        /// </summary>
        Value<string> PatientOutcome { get; }

        /// <summary>
        /// PEO-13: Event Description from Others
        /// </summary>
        ValueList<FT> EventDescriptionFromOthers { get; }

        /// <summary>
        /// PEO-14: Event Description from Original Reporter
        /// </summary>
        ValueList<FT> EventDescriptionFromOriginalReporter { get; }

        /// <summary>
        /// PEO-15: Event Description from Patient
        /// </summary>
        ValueList<FT> EventDescriptionFromPatient { get; }

        /// <summary>
        /// PEO-16: Event Description from Practitioner
        /// </summary>
        ValueList<FT> EventDescriptionFromPractitioner { get; }

        /// <summary>
        /// PEO-17: Event Description from Autopsy
        /// </summary>
        ValueList<FT> EventDescriptionFromAutopsy { get; }

        /// <summary>
        /// PEO-18: Cause Of Death
        /// </summary>
        ValueList<CWE> CauseOfDeath { get; }

        /// <summary>
        /// PEO-19: Primary Observer Name
        /// </summary>
        ValueList<XPN> PrimaryObserverName { get; }

        /// <summary>
        /// PEO-20: Primary Observer Address
        /// </summary>
        ValueList<XAD> PrimaryObserverAddress { get; }

        /// <summary>
        /// PEO-21: Primary Observer Telephone
        /// </summary>
        ValueList<XTN> PrimaryObserverTelephone { get; }

        /// <summary>
        /// PEO-22: Primary Observer's Qualification
        /// </summary>
        Value<string> PrimaryObserverSQualification { get; }

        /// <summary>
        /// PEO-23: Confirmation Provided By
        /// </summary>
        Value<string> ConfirmationProvidedBy { get; }

        /// <summary>
        /// PEO-24: Primary Observer Aware Date/Time
        /// </summary>
        Value<DateTimeOffset> PrimaryObserverAwareDateTime { get; }

        /// <summary>
        /// PEO-25: Primary Observer's identity May Be Divulged
        /// </summary>
        Value<string> PrimaryObserverSIdentityMayBeDivulged { get; }
    }
}