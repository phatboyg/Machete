// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DRG (SegmentMap) - Diagnosis Related Group
    /// </summary>
    public class DRGMap :
        HL7V26SegmentMap<DRG>
    {
        public DRGMap()
        {
            Id = "DRG";

            Name = "Diagnosis Related Group";

            Entity(x => x.DiagnosticRelatedGroup, 1);
            Value(x => x.DRGAssignedDateTime, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DRGApprovalIndicator, 3);
            Value(x => x.DRGGrouperReviewCode, 4);
            Entity(x => x.OutlierType, 5);
            Value(x => x.OutlierDays, 6);
            Entity(x => x.OutlierCost, 7);
            Value(x => x.DRGPayor, 8);
            Entity(x => x.OutlierReimbursement, 9);
            Value(x => x.ConfidentialIndicator, 10);
            Value(x => x.DRGTransferType, 11);
            Entity(x => x.NameOfCoder, 12);
            Entity(x => x.GrouperStatus, 13);
            Entity(x => x.PCCLValueCode, 14);
            Value(x => x.EffectiveWeight, 15);
            Entity(x => x.MonetaryAmount, 16);
            Value(x => x.StatusPatient, 17);
            Value(x => x.GrouperSoftwareName, 18);
            Value(x => x.GrouperSoftwareVersion, 19);
            Value(x => x.StatusFinancialCalculation, 20);
            Entity(x => x.RelativeDiscountSurcharge, 21);
            Entity(x => x.BasicCharge, 22);
            Entity(x => x.TotalCharge, 23);
            Entity(x => x.DiscountSurcharge, 24);
            Value(x => x.CalculatedDays, 25);
            Value(x => x.StatusGender, 26);
            Value(x => x.StatusAge, 27);
            Value(x => x.StatusLengthOfStay, 28);
            Value(x => x.StatusSameDayFlag, 29);
            Value(x => x.StatusSeparationMode, 30);
            Value(x => x.StatusWeightAtBirth, 31);
            Value(x => x.StatusRespirationMinutes, 32);
            Value(x => x.StatusAdmission, 33);
        }
    }
}