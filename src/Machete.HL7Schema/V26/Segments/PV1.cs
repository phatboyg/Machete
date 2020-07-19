// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PV1 (Segment) - Patient Visit
    /// </summary>
    public interface PV1 :
        HL7V26Segment
    {
        /// <summary>
        /// PV1-1: Set ID - PV1
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// PV1-2: Patient Class
        /// </summary>
        Value<string> PatientClass { get; }

        /// <summary>
        /// PV1-3: Assigned Patient Location
        /// </summary>
        Value<PL> AssignedPatientLocation { get; }

        /// <summary>
        /// PV1-4: Admission Type
        /// </summary>
        Value<string> AdmissionType { get; }

        /// <summary>
        /// PV1-5: Pre-admit Number
        /// </summary>
        Value<CX> PreAdmitNumber { get; }

        /// <summary>
        /// PV1-6: Prior Patient Location
        /// </summary>
        Value<PL> PriorPatientLocation { get; }

        /// <summary>
        /// PV1-7: Attending Doctor
        /// </summary>
        ValueList<XCN> AttendingDoctor { get; }

        /// <summary>
        /// PV1-8: Referring Doctor
        /// </summary>
        ValueList<XCN> ReferringDoctor { get; }

        /// <summary>
        /// PV1-9: Consulting Doctor
        /// </summary>
        ValueList<XCN> ConsultingDoctor { get; }

        /// <summary>
        /// PV1-10: Hospital Service
        /// </summary>
        Value<string> HospitalService { get; }

        /// <summary>
        /// PV1-11: Temporary Location
        /// </summary>
        Value<PL> TemporaryLocation { get; }

        /// <summary>
        /// PV1-12: Pre-admit Test Indicator
        /// </summary>
        Value<string> PreAdmitTestIndicator { get; }

        /// <summary>
        /// PV1-13: Re-admission Indicator
        /// </summary>
        Value<string> ReAdmissionIndicator { get; }

        /// <summary>
        /// PV1-14: Admit Source
        /// </summary>
        Value<string> AdmitSource { get; }

        /// <summary>
        /// PV1-15: Ambulatory Status
        /// </summary>
        ValueList<string> AmbulatoryStatus { get; }

        /// <summary>
        /// PV1-16: VIP Indicator
        /// </summary>
        Value<string> VIPIndicator { get; }

        /// <summary>
        /// PV1-17: Admitting Doctor
        /// </summary>
        ValueList<XCN> AdmittingDoctor { get; }

        /// <summary>
        /// PV1-18: Patient Type
        /// </summary>
        Value<string> PatientType { get; }

        /// <summary>
        /// PV1-19: Visit Number
        /// </summary>
        Value<CX> VisitNumber { get; }

        /// <summary>
        /// PV1-20: Financial Class
        /// </summary>
        ValueList<FC> FinancialClass { get; }

        /// <summary>
        /// PV1-21: Charge Price Indicator
        /// </summary>
        Value<string> ChargePriceIndicator { get; }

        /// <summary>
        /// PV1-22: Courtesy Code
        /// </summary>
        Value<string> CourtesyCode { get; }

        /// <summary>
        /// PV1-23: Credit Rating
        /// </summary>
        Value<string> CreditRating { get; }

        /// <summary>
        /// PV1-24: Contract Code
        /// </summary>
        ValueList<string> ContractCode { get; }

        /// <summary>
        /// PV1-25: Contract Effective Date
        /// </summary>
        ValueList<DateTimeOffset> ContractEffectiveDate { get; }

        /// <summary>
        /// PV1-26: Contract Amount
        /// </summary>
        ValueList<decimal> ContractAmount { get; }

        /// <summary>
        /// PV1-27: Contract Period
        /// </summary>
        ValueList<decimal> ContractPeriod { get; }

        /// <summary>
        /// PV1-28: Interest Code
        /// </summary>
        Value<string> InterestCode { get; }

        /// <summary>
        /// PV1-29: Transfer to Bad Debt Code
        /// </summary>
        Value<string> TransferToBadDebtCode { get; }

        /// <summary>
        /// PV1-30: Transfer to Bad Debt Date
        /// </summary>
        Value<DateTimeOffset> TransferToBadDebtDate { get; }

        /// <summary>
        /// PV1-31: Bad Debt Agency Code
        /// </summary>
        Value<string> BadDebtAgencyCode { get; }

        /// <summary>
        /// PV1-32: Bad Debt Transfer Amount
        /// </summary>
        Value<decimal> BadDebtTransferAmount { get; }

        /// <summary>
        /// PV1-33: Bad Debt Recovery Amount
        /// </summary>
        Value<decimal> BadDebtRecoveryAmount { get; }

        /// <summary>
        /// PV1-34: Delete Account Indicator
        /// </summary>
        Value<string> DeleteAccountIndicator { get; }

        /// <summary>
        /// PV1-35: Delete Account Date
        /// </summary>
        Value<DateTimeOffset> DeleteAccountDate { get; }

        /// <summary>
        /// PV1-36: Discharge Disposition
        /// </summary>
        Value<string> DischargeDisposition { get; }

        /// <summary>
        /// PV1-37: Discharged to Location
        /// </summary>
        Value<DLD> DischargedToLocation { get; }

        /// <summary>
        /// PV1-38: Diet Type
        /// </summary>
        Value<CWE> DietType { get; }

        /// <summary>
        /// PV1-39: Servicing Facility
        /// </summary>
        Value<string> ServicingFacility { get; }

        /// <summary>
        /// PV1-40: Bed Status
        /// </summary>
        Value<string> BedStatus { get; }

        /// <summary>
        /// PV1-41: Account Status
        /// </summary>
        Value<string> AccountStatus { get; }

        /// <summary>
        /// PV1-42: Pending Location
        /// </summary>
        Value<PL> PendingLocation { get; }

        /// <summary>
        /// PV1-43: Prior Temporary Location
        /// </summary>
        Value<PL> PriorTemporaryLocation { get; }

        /// <summary>
        /// PV1-44: Admit Date/Time
        /// </summary>
        Value<DateTimeOffset> AdmitDateTime { get; }

        /// <summary>
        /// PV1-45: Discharge Date/Time
        /// </summary>
        Value<DateTimeOffset> DischargeDateTime { get; }

        /// <summary>
        /// PV1-46: Current Patient Balance
        /// </summary>
        Value<decimal> CurrentPatientBalance { get; }

        /// <summary>
        /// PV1-47: Total Charges
        /// </summary>
        Value<decimal> TotalCharges { get; }

        /// <summary>
        /// PV1-48: Total Adjustments
        /// </summary>
        Value<decimal> TotalAdjustments { get; }

        /// <summary>
        /// PV1-49: Total Payments
        /// </summary>
        Value<decimal> TotalPayments { get; }

        /// <summary>
        /// PV1-50: Alternate Visit ID
        /// </summary>
        Value<CX> AlternateVisitId { get; }

        /// <summary>
        /// PV1-51: Visit Indicator
        /// </summary>
        Value<string> VisitIndicator { get; }

        /// <summary>
        /// PV1-52: Other Healthcare Provider
        /// </summary>
        ValueList<XCN> OtherHealthcareProvider { get; }
    }
}