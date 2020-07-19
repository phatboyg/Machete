// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PV2 (Segment) - Patient Visit - Additional Information
    /// </summary>
    public interface PV2 :
        HL7V26Segment
    {
        /// <summary>
        /// PV2-1: Prior Pending Location
        /// </summary>
        Value<PL> PriorPendingLocation { get; }

        /// <summary>
        /// PV2-2: Accommodation Code
        /// </summary>
        Value<CWE> AccommodationCode { get; }

        /// <summary>
        /// PV2-3: Admit Reason
        /// </summary>
        Value<CWE> AdmitReason { get; }

        /// <summary>
        /// PV2-4: Transfer Reason
        /// </summary>
        Value<CWE> TransferReason { get; }

        /// <summary>
        /// PV2-5: Patient Valuables
        /// </summary>
        ValueList<string> PatientValuables { get; }

        /// <summary>
        /// PV2-6: Patient Valuables Location
        /// </summary>
        Value<string> PatientValuablesLocation { get; }

        /// <summary>
        /// PV2-7: Visit User Code
        /// </summary>
        ValueList<string> VisitUserCode { get; }

        /// <summary>
        /// PV2-8: Expected Admit Date/Time
        /// </summary>
        Value<DateTimeOffset> ExpectedAdmitDateTime { get; }

        /// <summary>
        /// PV2-9: Expected Discharge Date/Time
        /// </summary>
        Value<DateTimeOffset> ExpectedDischargeDateTime { get; }

        /// <summary>
        /// PV2-10: Estimated Length of Inpatient Stay
        /// </summary>
        Value<decimal> EstimatedLengthOfInpatientStay { get; }

        /// <summary>
        /// PV2-11: Actual Length of Inpatient Stay
        /// </summary>
        Value<decimal> ActualLengthOfInpatientStay { get; }

        /// <summary>
        /// PV2-12: Visit Description
        /// </summary>
        Value<string> VisitDescription { get; }

        /// <summary>
        /// PV2-13: Referral Source Code
        /// </summary>
        ValueList<XCN> ReferralSourceCode { get; }

        /// <summary>
        /// PV2-14: Previous Service Date
        /// </summary>
        Value<DateTimeOffset> PreviousServiceDate { get; }

        /// <summary>
        /// PV2-15: Employment Illness Related Indicator
        /// </summary>
        Value<string> EmploymentIllnessRelatedIndicator { get; }

        /// <summary>
        /// PV2-16: Purge Status Code
        /// </summary>
        Value<string> PurgeStatusCode { get; }

        /// <summary>
        /// PV2-17: Purge Status Date
        /// </summary>
        Value<DateTimeOffset> PurgeStatusDate { get; }

        /// <summary>
        /// PV2-18: Special Program Code
        /// </summary>
        Value<string> SpecialProgramCode { get; }

        /// <summary>
        /// PV2-19: Retention Indicator
        /// </summary>
        Value<string> RetentionIndicator { get; }

        /// <summary>
        /// PV2-20: Expected Number of Insurance Plans
        /// </summary>
        Value<decimal> ExpectedNumberOfInsurancePlans { get; }

        /// <summary>
        /// PV2-21: Visit Publicity Code
        /// </summary>
        Value<string> VisitPublicityCode { get; }

        /// <summary>
        /// PV2-22: Visit Protection Indicator
        /// </summary>
        Value<string> VisitProtectionIndicator { get; }

        /// <summary>
        /// PV2-23: Clinic Organization Name
        /// </summary>
        ValueList<XON> ClinicOrganizationName { get; }

        /// <summary>
        /// PV2-24: Patient Status Code
        /// </summary>
        Value<string> PatientStatusCode { get; }

        /// <summary>
        /// PV2-25: Visit Priority Code
        /// </summary>
        Value<string> VisitPriorityCode { get; }

        /// <summary>
        /// PV2-26: Previous Treatment Date
        /// </summary>
        Value<DateTimeOffset> PreviouTreatmentDate { get; }

        /// <summary>
        /// PV2-27: Expected Discharge Disposition
        /// </summary>
        Value<string> ExpectedDischargeDisposition { get; }

        /// <summary>
        /// PV2-28: Signature on File Date
        /// </summary>
        Value<DateTimeOffset> SignatureOnFileDate { get; }

        /// <summary>
        /// PV2-29: First Similar Illness Date
        /// </summary>
        Value<DateTimeOffset> FirstSimilarIllnessDate { get; }

        /// <summary>
        /// PV2-30: Patient Charge Adjustment Code
        /// </summary>
        Value<CWE> PatientChargeAdjustmentCode { get; }

        /// <summary>
        /// PV2-31: Recurring Service Code
        /// </summary>
        Value<string> RecurringServiceCode { get; }

        /// <summary>
        /// PV2-32: Billing Media Code
        /// </summary>
        Value<string> BillingMediaCode { get; }

        /// <summary>
        /// PV2-33: Expected Surgery Date and Time
        /// </summary>
        Value<DateTimeOffset> ExpectedSurgeryDateAndTime { get; }

        /// <summary>
        /// PV2-34: Military Partnership Code
        /// </summary>
        Value<string> MilitaryPartnershipCode { get; }

        /// <summary>
        /// PV2-35: Military Non-Availability Code
        /// </summary>
        Value<string> MilitaryNonAvailabilityCode { get; }

        /// <summary>
        /// PV2-36: Newborn Baby Indicator
        /// </summary>
        Value<string> NewbornBabyIndicator { get; }

        /// <summary>
        /// PV2-37: Baby Detained Indicator
        /// </summary>
        Value<string> BabyDetainedIndicator { get; }

        /// <summary>
        /// PV2-38: Mode of Arrival Code
        /// </summary>
        Value<CWE> ModeOfArrivalCode { get; }

        /// <summary>
        /// PV2-39: Recreational Drug Use Code
        /// </summary>
        ValueList<CWE> RecreationalDrugUseCode { get; }

        /// <summary>
        /// PV2-40: Admission Level of Care Code
        /// </summary>
        Value<CWE> AdmissionLevelOfCareCode { get; }

        /// <summary>
        /// PV2-41: Precaution Code
        /// </summary>
        ValueList<CWE> PrecautionCode { get; }

        /// <summary>
        /// PV2-42: Patient Condition Code
        /// </summary>
        Value<CWE> PatientConditionCode { get; }

        /// <summary>
        /// PV2-43: Living Will Code
        /// </summary>
        Value<string> LivingWillCode { get; }

        /// <summary>
        /// PV2-44: Organ Donor Code
        /// </summary>
        Value<string> OrganDonorCode { get; }

        /// <summary>
        /// PV2-45: Advance Directive Code
        /// </summary>
        ValueList<CWE> AdvanceDirectiveCode { get; }

        /// <summary>
        /// PV2-46: Patient Status Effective Date
        /// </summary>
        Value<DateTimeOffset> PatientStatusEffectiveDate { get; }

        /// <summary>
        /// PV2-47: Expected LOA Return Date/Time
        /// </summary>
        Value<DateTimeOffset> ExpectedLOAReturnDateTime { get; }

        /// <summary>
        /// PV2-48: Expected Pre-admission Testing Date/Time
        /// </summary>
        Value<DateTimeOffset> ExpectedPreAdmissionTestingDateTime { get; }

        /// <summary>
        /// PV2-49: Notify Clergy Code
        /// </summary>
        ValueList<string> NotifyClergyCode { get; }

        /// <summary>
        /// PV2-50: Advance Directive Last Verified Date
        /// </summary>
        Value<DateTimeOffset> AdvanceDirectiveLastVerifiedDate { get; }
    }
}