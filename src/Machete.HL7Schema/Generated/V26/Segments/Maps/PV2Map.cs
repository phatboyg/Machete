// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PV2 (SegmentMap) - Patient Visit - Additional Information
    /// </summary>
    public class PV2Map :
        HL7V26SegmentMap<PV2>
    {
        public PV2Map()
        {
            Id = "PV2";

            Name = "Patient Visit - Additional Information";

            Entity(x => x.PriorPendingLocation, 1);
            Entity(x => x.AccommodationCode, 2);
            Entity(x => x.AdmitReason, 3);
            Entity(x => x.TransferReason, 4);
            Value(x => x.PatientValuables, 5);
            Value(x => x.PatientValuablesLocation, 6);
            Value(x => x.VisitUserCode, 7);
            Value(x => x.ExpectedAdmitDateTime, 8, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpectedDischargeDateTime, 9, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EstimatedLengthOfInpatientStay, 10);
            Value(x => x.ActualLengthOfInpatientStay, 11);
            Value(x => x.VisitDescription, 12);
            Entity(x => x.ReferralSourceCode, 13);
            Value(x => x.PreviousServiceDate, 14, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EmploymentIllnessRelatedIndicator, 15);
            Value(x => x.PurgeStatusCode, 16);
            Value(x => x.PurgeStatusDate, 17, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.SpecialProgramCode, 18);
            Value(x => x.RetentionIndicator, 19);
            Value(x => x.ExpectedNumberOfInsurancePlans, 20);
            Value(x => x.VisitPublicityCode, 21);
            Value(x => x.VisitProtectionIndicator, 22);
            Entity(x => x.ClinicOrganizationName, 23);
            Value(x => x.PatientStatusCode, 24);
            Value(x => x.VisitPriorityCode, 25);
            Value(x => x.PreviouTreatmentDate, 26, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpectedDischargeDisposition, 27);
            Value(x => x.SignatureOnFileDate, 28, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.FirstSimilarIllnessDate, 29, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.PatientChargeAdjustmentCode, 30);
            Value(x => x.RecurringServiceCode, 31);
            Value(x => x.BillingMediaCode, 32);
            Value(x => x.ExpectedSurgeryDateAndTime, 33, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.MilitaryPartnershipCode, 34);
            Value(x => x.MilitaryNonAvailabilityCode, 35);
            Value(x => x.NewbornBabyIndicator, 36);
            Value(x => x.BabyDetainedIndicator, 37);
            Entity(x => x.ModeOfArrivalCode, 38);
            Entity(x => x.RecreationalDrugUseCode, 39);
            Entity(x => x.AdmissionLevelOfCareCode, 40);
            Entity(x => x.PrecautionCode, 41);
            Entity(x => x.PatientConditionCode, 42);
            Value(x => x.LivingWillCode, 43);
            Value(x => x.OrganDonorCode, 44);
            Entity(x => x.AdvanceDirectiveCode, 45);
            Value(x => x.PatientStatusEffectiveDate, 46, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpectedLOAReturnDateTime, 47, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.ExpectedPreAdmissionTestingDateTime, 48, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.NotifyClergyCode, 49);
            Value(x => x.AdvanceDirectiveLastVerifiedDate, 50, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}