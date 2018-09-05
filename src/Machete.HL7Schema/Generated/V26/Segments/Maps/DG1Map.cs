// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DG1 (SegmentMap) - Diagnosis
    /// </summary>
    public class DG1Map :
        HL7V26SegmentMap<DG1>
    {
        public DG1Map()
        {
            Id = "DG1";

            Name = "Diagnosis";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Value(x => x.DiagnosisCodingMethod, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.DiagnosisCode, 3, x => {x.Required = true;});
            Value(x => x.DiagnosisDescription, 4, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DiagnosisDateTime, 5, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DiagnosisType, 6, x => {x.Required = true;});
            Entity(x => x.MajorDiagnosticCategory, 7);
            Entity(x => x.DiagnosticRelatedGroup, 8);
            Value(x => x.DRGApprovalIndicator, 9);
            Value(x => x.DRGGrouperReviewCode, 10);
            Entity(x => x.OutlierType, 11);
            Value(x => x.OutlierDays, 12);
            Entity(x => x.OutlierCost, 13);
            Value(x => x.GrouperVersionAndType, 14, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.DiagnosisPriority, 15);
            Entity(x => x.DiagnosingClinician, 16);
            Value(x => x.DiagnosisClassification, 17);
            Value(x => x.ConfidentialIndicator, 18);
            Value(x => x.AttestationDateTime, 19, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.DiagnosisIdentifier, 20);
            Value(x => x.DiagnosisActionCode, 21);
            Entity(x => x.ParentDiagnosis, 22);
            Entity(x => x.DRGCCLValueCode, 23);
            Value(x => x.DRGGroupingUsage, 24);
            Value(x => x.DRGDiagnosisDeterminationStatus, 25);
            Value(x => x.PresentOnAdmissionIndicator, 26);
        }
    }
}