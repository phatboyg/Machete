namespace Machete.HL7.Tests.TestSchema
{
    public class PV1SegmentMap :
        HL7SegmentMap<PV1Segment, HL7Entity>
    {
        public PV1SegmentMap()
        {
            Id = "PV1";

            Name = "Patient Visit";

            Value(x => x.SetId, 1);
            Value(x => x.PatientClass, 2, x => {x.Required = true;});
            Entity(x => x.AssignedPatientLocation, 3);
            Value(x => x.AdmissionType, 4);
            Entity(x => x.PreadmitNumber, 5);
            Entity(x => x.PriorPatientLocation, 6);
            Entity(x => x.AttendingDoctor, 7);
            Entity(x => x.ReferringDoctor, 8);
            Entity(x => x.ConsultingDoctor, 9);
            Value(x => x.HospitalService, 10);
            Entity(x => x.TemporaryLocation, 11);
            Value(x => x.PreadmitTestIndicator, 12);
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
            Value(x => x.ContractEffectiveDate, 25, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ContractAmount, 26);
            Value(x => x.ContractPeriod, 27);
            Value(x => x.InterestCode, 28);
            Value(x => x.TransferToBadDebtCode, 29);
            Value(x => x.TransferToBadDebtDate, 30, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.BadDebtAgencyCode, 31);
            Value(x => x.BadDebtTransferAmount, 32);
            Value(x => x.BadDebtRecoveryAmount, 33);
            Value(x => x.DeleteAccountIndicator, 34);
            Value(x => x.DeleteAccountDate, 35, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DischargeDisposition, 36);
        }
    }
}