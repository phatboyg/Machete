namespace Machete.HL7.Tests.TestSchema
{
    using System;


    public interface PV1Segment :
        HL7Segment
    {
        Value<int> SetId { get; }
        Value<string> PatientClass { get; }
        Value<PLComponent> AssignedPatientLocation { get; }
        Value<string> AdmissionType { get; }
        Value<CXComponent> PreadmitNumber { get; }
        Value<PLComponent> PriorPatientLocation { get; }
        ValueList<XCNComponent> AttendingDoctor { get; }
        ValueList<XCNComponent> ReferringDoctor { get; }
        ValueList<XCNComponent> ConsultingDoctor { get; }
        Value<string> HospitalService { get; }
        Value<PLComponent> TemporaryLocation { get; }
        Value<string> PreadmitTestIndicator { get; }
        Value<string> ReAdmissionIndicator { get; }
        Value<string> AdmitSource { get; }
        ValueList<string> AmbulatoryStatus { get; }
        Value<string> VIPIndicator { get; }
        ValueList<XCNComponent> AdmittingDoctor { get; }
        Value<string> PatientType { get; }
        Value<CXComponent> VisitNumber { get; }
        ValueList<FCComponent> FinancialClass { get; }
        Value<string> ChargePriceIndicator { get; }
        Value<string> CourtesyCode { get; }
        Value<string> CreditRating { get; }
        ValueList<string> ContractCode { get; }
        ValueList<DateTimeOffset> ContractEffectiveDate { get; }
        ValueList<decimal> ContractAmount { get; }
        ValueList<decimal> ContractPeriod { get; }
        Value<string> InterestCode { get; }
        Value<string> TransferToBadDebtCode { get; }
        Value<DateTimeOffset> TransferToBadDebtDate { get; }
        Value<string> BadDebtAgencyCode { get; }
        Value<decimal> BadDebtTransferAmount { get; }
        Value<decimal> BadDebtRecoveryAmount { get; }
        Value<string> DeleteAccountIndicator { get; }
        Value<DateTimeOffset> DeleteAccountDate { get; }
        Value<string> DischargeDisposition { get; }
    }
}