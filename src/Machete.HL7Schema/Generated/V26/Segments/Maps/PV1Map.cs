// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PV1 (SegmentMap) - Patient Visit
    /// </summary>
    public class PV1Map :
        HL7V26SegmentMap<PV1>
    {
        public PV1Map()
        {
            Id = "PV1";

            Name = "Patient Visit";

            Value(x => x.SetId, 1);
            Value(x => x.PatientClass, 2, x => {x.Required = true;});
            Entity(x => x.AssignedPatientLocation, 3);
            Value(x => x.AdmissionType, 4);
            Entity(x => x.PreAdmitNumber, 5);
            Entity(x => x.PriorPatientLocation, 6);
            Entity(x => x.AttendingDoctor, 7);
            Entity(x => x.ReferringDoctor, 8);
            Entity(x => x.ConsultingDoctor, 9);
            Value(x => x.HospitalService, 10);
            Entity(x => x.TemporaryLocation, 11);
            Value(x => x.PreAdmitTestIndicator, 12);
            Value(x => x.ReAdmissionIndicator, 13);
            Value(x => x.AdmitSource, 14);
            Value(x => x.AmbulatoryStatus, 15);
            Value(x => x.VIPIndicator, 16);
            Entity(x => x.AdmittingDoctor, 17);
            Value(x => x.PatientType, 18);
            Entity(x => x.VisitNumber, 19);
            Entity(x => x.FinancialClass, 20);
            Value(x => x.ChargePriceIndicator, 21);
            Value(x => x.CourtesyCode, 22);
            Value(x => x.CreditRating, 23);
            Value(x => x.ContractCode, 24);
            Value(x => x.ContractEffectiveDate, 25, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ContractAmount, 26);
            Value(x => x.ContractPeriod, 27);
            Value(x => x.InterestCode, 28);
            Value(x => x.TransferToBadDebtCode, 29);
            Value(x => x.TransferToBadDebtDate, 30, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.BadDebtAgencyCode, 31);
            Value(x => x.BadDebtTransferAmount, 32);
            Value(x => x.BadDebtRecoveryAmount, 33);
            Value(x => x.DeleteAccountIndicator, 34);
            Value(x => x.DeleteAccountDate, 35, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DischargeDisposition, 36);
            Entity(x => x.DischargedToLocation, 37);
            Entity(x => x.DietType, 38);
            Value(x => x.ServicingFacility, 39);
            Value(x => x.BedStatus, 40);
            Value(x => x.AccountStatus, 41);
            Entity(x => x.PendingLocation, 42);
            Entity(x => x.PriorTemporaryLocation, 43);
            Value(x => x.AdmitDateTime, 44, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DischargeDateTime, 45, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.CurrentPatientBalance, 46);
            Value(x => x.TotalCharges, 47);
            Value(x => x.TotalAdjustments, 48);
            Value(x => x.TotalPayments, 49);
            Entity(x => x.AlternateVisitId, 50);
            Value(x => x.VisitIndicator, 51);
            Entity(x => x.OtherHealthcareProvider, 52);
        }
    }
}