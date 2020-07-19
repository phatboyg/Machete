// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// DRG (Segment) - Diagnosis Related Group
    /// </summary>
    public interface DRG :
        HL7V26Segment
    {
        /// <summary>
        /// DRG-1: Diagnostic Related Group
        /// </summary>
        Value<CNE> DiagnosticRelatedGroup { get; }

        /// <summary>
        /// DRG-2: DRG Assigned Date/Time
        /// </summary>
        Value<DateTimeOffset> DRGAssignedDateTime { get; }

        /// <summary>
        /// DRG-3: DRG Approval Indicator
        /// </summary>
        Value<string> DRGApprovalIndicator { get; }

        /// <summary>
        /// DRG-4: DRG Grouper Review Code
        /// </summary>
        Value<string> DRGGrouperReviewCode { get; }

        /// <summary>
        /// DRG-5: Outlier Type
        /// </summary>
        Value<CWE> OutlierType { get; }

        /// <summary>
        /// DRG-6: Outlier Days
        /// </summary>
        Value<decimal> OutlierDays { get; }

        /// <summary>
        /// DRG-7: Outlier Cost
        /// </summary>
        Value<CP> OutlierCost { get; }

        /// <summary>
        /// DRG-8: DRG Payor
        /// </summary>
        Value<string> DRGPayor { get; }

        /// <summary>
        /// DRG-9: Outlier Reimbursement
        /// </summary>
        Value<CP> OutlierReimbursement { get; }

        /// <summary>
        /// DRG-10: Confidential Indicator
        /// </summary>
        Value<string> ConfidentialIndicator { get; }

        /// <summary>
        /// DRG-11: DRG Transfer Type
        /// </summary>
        Value<string> DRGTransferType { get; }

        /// <summary>
        /// DRG-12: Name of Coder
        /// </summary>
        Value<XPN> NameOfCoder { get; }

        /// <summary>
        /// DRG-13: Grouper Status
        /// </summary>
        Value<CWE> GrouperStatus { get; }

        /// <summary>
        /// DRG-14: PCCL Value Code
        /// </summary>
        Value<CWE> PCCLValueCode { get; }

        /// <summary>
        /// DRG-15: Effective Weight
        /// </summary>
        Value<decimal> EffectiveWeight { get; }

        /// <summary>
        /// DRG-16: Monetary Amount
        /// </summary>
        Value<MO> MonetaryAmount { get; }

        /// <summary>
        /// DRG-17: Status Patient
        /// </summary>
        Value<string> StatusPatient { get; }

        /// <summary>
        /// DRG-18: Grouper Software Name
        /// </summary>
        Value<string> GrouperSoftwareName { get; }

        /// <summary>
        /// DRG-19: Grouper Software Version
        /// </summary>
        Value<string> GrouperSoftwareVersion { get; }

        /// <summary>
        /// DRG-20: Status Financial Calculation
        /// </summary>
        Value<string> StatusFinancialCalculation { get; }

        /// <summary>
        /// DRG-21: Relative Discount/Surcharge
        /// </summary>
        Value<MO> RelativeDiscountSurcharge { get; }

        /// <summary>
        /// DRG-22: Basic Charge
        /// </summary>
        Value<MO> BasicCharge { get; }

        /// <summary>
        /// DRG-23: Total Charge
        /// </summary>
        Value<MO> TotalCharge { get; }

        /// <summary>
        /// DRG-24: Discount/Surcharge
        /// </summary>
        Value<MO> DiscountSurcharge { get; }

        /// <summary>
        /// DRG-25: Calculated Days
        /// </summary>
        Value<decimal> CalculatedDays { get; }

        /// <summary>
        /// DRG-26: Status Gender
        /// </summary>
        Value<string> StatusGender { get; }

        /// <summary>
        /// DRG-27: Status Age
        /// </summary>
        Value<string> StatusAge { get; }

        /// <summary>
        /// DRG-28: Status Length of Stay
        /// </summary>
        Value<string> StatusLengthOfStay { get; }

        /// <summary>
        /// DRG-29: Status Same Day Flag
        /// </summary>
        Value<string> StatusSameDayFlag { get; }

        /// <summary>
        /// DRG-30: Status Separation Mode
        /// </summary>
        Value<string> StatusSeparationMode { get; }

        /// <summary>
        /// DRG-31: Status Weight at Birth
        /// </summary>
        Value<string> StatusWeightAtBirth { get; }

        /// <summary>
        /// DRG-32: Status Respiration Minutes
        /// </summary>
        Value<string> StatusRespirationMinutes { get; }

        /// <summary>
        /// DRG-33: Status Admission
        /// </summary>
        Value<string> StatusAdmission { get; }
    }
}