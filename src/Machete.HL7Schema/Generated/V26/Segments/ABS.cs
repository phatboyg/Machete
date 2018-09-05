// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// ABS (Segment) - Abstract
    /// </summary>
    public interface ABS :
        HL7V26Segment
    {
        /// <summary>
        /// ABS-1: Discharge Care Provider
        /// </summary>
        Value<XCN> DischargeCareProvider { get; }

        /// <summary>
        /// ABS-2: Transfer Medical Service Code
        /// </summary>
        Value<CWE> TransferMedicalServiceCode { get; }

        /// <summary>
        /// ABS-3: Severity of Illness Code
        /// </summary>
        Value<CWE> SeverityOfIllnessCode { get; }

        /// <summary>
        /// ABS-4: Date/Time of Attestation
        /// </summary>
        Value<DateTimeOffset> DateTimeOfAttestation { get; }

        /// <summary>
        /// ABS-5: Attested By
        /// </summary>
        Value<XCN> AttestedBy { get; }

        /// <summary>
        /// ABS-6: Triage Code
        /// </summary>
        Value<CWE> TriageCode { get; }

        /// <summary>
        /// ABS-7: Abstract Completion Date/Time
        /// </summary>
        Value<DateTimeOffset> AbstractCompletionDateTime { get; }

        /// <summary>
        /// ABS-8: Abstracted By
        /// </summary>
        Value<XCN> AbstractedBy { get; }

        /// <summary>
        /// ABS-9: Case Category Code
        /// </summary>
        Value<CWE> CaseCategoryCode { get; }

        /// <summary>
        /// ABS-10: Caesarean Section Indicator
        /// </summary>
        Value<string> CaesareanSectionIndicator { get; }

        /// <summary>
        /// ABS-11: Gestation Category Code
        /// </summary>
        Value<CWE> GestationCategoryCode { get; }

        /// <summary>
        /// ABS-12: Gestation Period - Weeks
        /// </summary>
        Value<decimal> GestationPeriodWeeks { get; }

        /// <summary>
        /// ABS-13: Newborn Code
        /// </summary>
        Value<CWE> NewbornCode { get; }

        /// <summary>
        /// ABS-14: Stillborn Indicator
        /// </summary>
        Value<string> StillbornIndicator { get; }
    }
}