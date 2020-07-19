// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// DG1 (Segment) - Diagnosis
    /// </summary>
    public interface DG1 :
        HL7V26Segment
    {
        /// <summary>
        /// DG1-1: Set ID - DG1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// DG1-2: Diagnosis Coding Method
        /// </summary>
        Value<DateTimeOffset> DiagnosisCodingMethod { get; }

        /// <summary>
        /// DG1-3: Diagnosis Code - DG1
        /// </summary>
        Value<CWE> DiagnosisCode { get; }

        /// <summary>
        /// DG1-4: Diagnosis Description
        /// </summary>
        Value<DateTimeOffset> DiagnosisDescription { get; }

        /// <summary>
        /// DG1-5: Diagnosis Date/Time
        /// </summary>
        Value<DateTimeOffset> DiagnosisDateTime { get; }

        /// <summary>
        /// DG1-6: Diagnosis Type
        /// </summary>
        Value<string> DiagnosisType { get; }

        /// <summary>
        /// DG1-7: Major Diagnostic Category
        /// </summary>
        Value<CNE> MajorDiagnosticCategory { get; }

        /// <summary>
        /// DG1-8: Diagnostic Related Group
        /// </summary>
        Value<CNE> DiagnosticRelatedGroup { get; }

        /// <summary>
        /// DG1-9: DRG Approval Indicator
        /// </summary>
        Value<string> DRGApprovalIndicator { get; }

        /// <summary>
        /// DG1-10: DRG Grouper Review Code
        /// </summary>
        Value<string> DRGGrouperReviewCode { get; }

        /// <summary>
        /// DG1-11: Outlier Type
        /// </summary>
        Value<CWE> OutlierType { get; }

        /// <summary>
        /// DG1-12: Outlier Days
        /// </summary>
        Value<decimal> OutlierDays { get; }

        /// <summary>
        /// DG1-13: Outlier Cost
        /// </summary>
        Value<CP> OutlierCost { get; }

        /// <summary>
        /// DG1-14: Grouper Version And Type
        /// </summary>
        Value<DateTimeOffset> GrouperVersionAndType { get; }

        /// <summary>
        /// DG1-15: Diagnosis Priority
        /// </summary>
        Value<string> DiagnosisPriority { get; }

        /// <summary>
        /// DG1-16: Diagnosing Clinician
        /// </summary>
        ValueList<XCN> DiagnosingClinician { get; }

        /// <summary>
        /// DG1-17: Diagnosis Classification
        /// </summary>
        Value<string> DiagnosisClassification { get; }

        /// <summary>
        /// DG1-18: Confidential Indicator
        /// </summary>
        Value<string> ConfidentialIndicator { get; }

        /// <summary>
        /// DG1-19: Attestation Date/Time
        /// </summary>
        Value<DateTimeOffset> AttestationDateTime { get; }

        /// <summary>
        /// DG1-20: Diagnosis Identifier
        /// </summary>
        Value<EI> DiagnosisIdentifier { get; }

        /// <summary>
        /// DG1-21: Diagnosis Action Code
        /// </summary>
        Value<string> DiagnosisActionCode { get; }

        /// <summary>
        /// DG1-22: Parent Diagnosis
        /// </summary>
        Value<EI> ParentDiagnosis { get; }

        /// <summary>
        /// DG1-23: DRG CCL Value Code
        /// </summary>
        Value<CWE> DRGCCLValueCode { get; }

        /// <summary>
        /// DG1-24: DRG Grouping Usage
        /// </summary>
        Value<string> DRGGroupingUsage { get; }

        /// <summary>
        /// DG1-25: DRG Diagnosis Determination Status
        /// </summary>
        Value<string> DRGDiagnosisDeterminationStatus { get; }

        /// <summary>
        /// DG1-26: Present On Admission (POA) Indicator
        /// </summary>
        Value<string> PresentOnAdmissionIndicator { get; }
    }
}