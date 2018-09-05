// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// FT1 (Segment) - Financial Transaction
    /// </summary>
    public interface FT1 :
        HL7V26Segment
    {
        /// <summary>
        /// FT1-1: Set ID - FT1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// FT1-2: Transaction ID
        /// </summary>
        Value<string> TransactionId { get; }

        /// <summary>
        /// FT1-3: Transaction Batch ID
        /// </summary>
        Value<string> TransactionBatchId { get; }

        /// <summary>
        /// FT1-4: Transaction Date
        /// </summary>
        Value<DR> TransactionDate { get; }

        /// <summary>
        /// FT1-5: Transaction Posting Date
        /// </summary>
        Value<DateTimeOffset> TransactionPostingDate { get; }

        /// <summary>
        /// FT1-6: Transaction Type
        /// </summary>
        Value<string> TransactionType { get; }

        /// <summary>
        /// FT1-7: Transaction Code
        /// </summary>
        Value<CWE> TransactionCode { get; }

        /// <summary>
        /// FT1-8: Transaction Description
        /// </summary>
        Value<DateTimeOffset> TransactionDescription { get; }

        /// <summary>
        /// FT1-9: Transaction Description - Alt
        /// </summary>
        Value<DateTimeOffset> TransactionDescriptionAlt { get; }

        /// <summary>
        /// FT1-10: Transaction Quantity
        /// </summary>
        Value<decimal> TransactionQuantity { get; }

        /// <summary>
        /// FT1-11: Transaction Amount - Extended
        /// </summary>
        Value<CP> TransactionAmountExtended { get; }

        /// <summary>
        /// FT1-12: Transaction amount - unit
        /// </summary>
        Value<CP> TransactionAmountUnit { get; }

        /// <summary>
        /// FT1-13: Department Code
        /// </summary>
        Value<CWE> DepartmentCode { get; }

        /// <summary>
        /// FT1-14: Insurance Plan ID
        /// </summary>
        Value<CWE> InsurancePlanId { get; }

        /// <summary>
        /// FT1-15: Insurance Amount
        /// </summary>
        Value<CP> InsuranceAmount { get; }

        /// <summary>
        /// FT1-16: Assigned Patient Location
        /// </summary>
        Value<PL> AssignedPatientLocation { get; }

        /// <summary>
        /// FT1-17: Fee Schedule
        /// </summary>
        Value<string> FeeSchedule { get; }

        /// <summary>
        /// FT1-18: Patient Type
        /// </summary>
        Value<string> PatientType { get; }

        /// <summary>
        /// FT1-19: Diagnosis Code - FT1
        /// </summary>
        ValueList<CWE> DiagnosisCode { get; }

        /// <summary>
        /// FT1-20: Performed By Code
        /// </summary>
        ValueList<XCN> PerformedByCode { get; }

        /// <summary>
        /// FT1-21: Ordered By Code
        /// </summary>
        ValueList<XCN> OrderedByCode { get; }

        /// <summary>
        /// FT1-22: Unit Cost
        /// </summary>
        Value<CP> UnitCost { get; }

        /// <summary>
        /// FT1-23: Filler Order Number
        /// </summary>
        Value<EI> FillerOrderNumber { get; }

        /// <summary>
        /// FT1-24: Entered By Code
        /// </summary>
        ValueList<XCN> EnteredByCode { get; }

        /// <summary>
        /// FT1-25: Procedure Code
        /// </summary>
        Value<CNE> ProcedureCode { get; }

        /// <summary>
        /// FT1-26: Procedure Code Modifier
        /// </summary>
        ValueList<CNE> ProcedureCodeModifier { get; }

        /// <summary>
        /// FT1-27: Advanced Beneficiary Notice Code
        /// </summary>
        Value<CWE> AdvancedBeneficiaryNoticeCode { get; }

        /// <summary>
        /// FT1-28: Medically Necessary Duplicate Procedure Reason
        /// </summary>
        Value<CWE> MedicallyNecessaryDuplicateProcedureReason { get; }

        /// <summary>
        /// FT1-29: NDC Code
        /// </summary>
        Value<CWE> NDCCode { get; }

        /// <summary>
        /// FT1-30: Payment Reference ID
        /// </summary>
        Value<CX> PaymentReferenceId { get; }

        /// <summary>
        /// FT1-31: Transaction Reference Key
        /// </summary>
        ValueList<int> TransactionReferenceKey { get; }
    }
}