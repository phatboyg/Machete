// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// FT1 (SegmentMap) - Financial Transaction
    /// </summary>
    public class FT1Map :
        HL7V26SegmentMap<FT1>
    {
        public FT1Map()
        {
            Id = "FT1";

            Name = "Financial Transaction";

            Value(x => x.SetId, 1);
            Value(x => x.TransactionId, 2);
            Value(x => x.TransactionBatchId, 3);
            Entity(x => x.TransactionDate, 4, x => {x.Required = true;});
            Value(x => x.TransactionPostingDate, 5, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.TransactionType, 6, x => {x.Required = true;});
            Entity(x => x.TransactionCode, 7, x => {x.Required = true;});
            Value(x => x.TransactionDescription, 8, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.TransactionDescriptionAlt, 9, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.TransactionQuantity, 10);
            Entity(x => x.TransactionAmountExtended, 11);
            Entity(x => x.TransactionAmountUnit, 12);
            Entity(x => x.DepartmentCode, 13);
            Entity(x => x.InsurancePlanId, 14);
            Entity(x => x.InsuranceAmount, 15);
            Entity(x => x.AssignedPatientLocation, 16);
            Value(x => x.FeeSchedule, 17);
            Value(x => x.PatientType, 18);
            Entity(x => x.DiagnosisCode, 19);
            Entity(x => x.PerformedByCode, 20);
            Entity(x => x.OrderedByCode, 21);
            Entity(x => x.UnitCost, 22);
            Entity(x => x.FillerOrderNumber, 23);
            Entity(x => x.EnteredByCode, 24);
            Entity(x => x.ProcedureCode, 25);
            Entity(x => x.ProcedureCodeModifier, 26);
            Entity(x => x.AdvancedBeneficiaryNoticeCode, 27);
            Entity(x => x.MedicallyNecessaryDuplicateProcedureReason, 28);
            Entity(x => x.NDCCode, 29);
            Entity(x => x.PaymentReferenceId, 30);
            Value(x => x.TransactionReferenceKey, 31);
        }
    }
}