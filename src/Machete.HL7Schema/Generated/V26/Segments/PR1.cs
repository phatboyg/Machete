// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PR1 (Segment) - Procedures
    /// </summary>
    public interface PR1 :
        HL7V26Segment
    {
        /// <summary>
        /// PR1-1: Set ID - PR1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// PR1-2: Procedure Coding Method
        /// </summary>
        Value<DateTimeOffset> ProcedureCodingMethod { get; }

        /// <summary>
        /// PR1-3: Procedure Code
        /// </summary>
        Value<CNE> ProcedureCode { get; }

        /// <summary>
        /// PR1-4: Procedure Description
        /// </summary>
        Value<DateTimeOffset> ProcedureDescription { get; }

        /// <summary>
        /// PR1-5: Procedure Date/Time
        /// </summary>
        Value<DateTimeOffset> ProcedureDateTime { get; }

        /// <summary>
        /// PR1-6: Procedure Functional Type
        /// </summary>
        Value<string> ProcedureFunctionalType { get; }

        /// <summary>
        /// PR1-7: Procedure Minutes
        /// </summary>
        Value<decimal> ProcedureMinutes { get; }

        /// <summary>
        /// PR1-8: Anesthesiologist
        /// </summary>
        Value<DateTimeOffset> Anesthesiologist { get; }

        /// <summary>
        /// PR1-9: Anesthesia Code
        /// </summary>
        Value<string> AnesthesiaCode { get; }

        /// <summary>
        /// PR1-10: Anesthesia Minutes
        /// </summary>
        Value<decimal> AnesthesiaMinutes { get; }

        /// <summary>
        /// PR1-11: Surgeon
        /// </summary>
        Value<DateTimeOffset> Surgeon { get; }

        /// <summary>
        /// PR1-12: Procedure Practitioner
        /// </summary>
        Value<DateTimeOffset> ProcedurePractitioner { get; }

        /// <summary>
        /// PR1-13: Consent Code
        /// </summary>
        Value<CWE> ConsentCode { get; }

        /// <summary>
        /// PR1-14: Procedure Priority
        /// </summary>
        Value<string> ProcedurePriority { get; }

        /// <summary>
        /// PR1-15: Associated Diagnosis Code
        /// </summary>
        Value<CWE> AssociatedDiagnosisCode { get; }

        /// <summary>
        /// PR1-16: Procedure Code Modifier
        /// </summary>
        ValueList<CNE> ProcedureCodeModifier { get; }

        /// <summary>
        /// PR1-17: Procedure DRG Type
        /// </summary>
        Value<string> ProcedureDRGType { get; }

        /// <summary>
        /// PR1-18: Tissue Type Code
        /// </summary>
        ValueList<CWE> TissueTypeCode { get; }

        /// <summary>
        /// PR1-19: Procedure Identifier
        /// </summary>
        Value<EI> ProcedureIdentifier { get; }

        /// <summary>
        /// PR1-20: Procedure Action Code
        /// </summary>
        Value<string> ProcedureActionCode { get; }

        /// <summary>
        /// PR1-21: DRG Procedure Determination Status
        /// </summary>
        Value<string> DRGProcedureDeterminationStatus { get; }

        /// <summary>
        /// PR1-22: DRG Procedure Relevance
        /// </summary>
        Value<string> DRGProcedureRelevance { get; }
    }
}