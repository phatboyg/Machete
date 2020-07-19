// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PR1 (SegmentMap) - Procedures
    /// </summary>
    public class PR1Map :
        HL7V26SegmentMap<PR1>
    {
        public PR1Map()
        {
            Id = "PR1";

            Name = "Procedures";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.ProcedureCodingMethod, 2, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ProcedureCode, 3, x => x.IsRequired());
            Value(x => x.ProcedureDescription, 4, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ProcedureDateTime, 5, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.ProcedureFunctionalType, 6);
            Value(x => x.ProcedureMinutes, 7);
            Value(x => x.Anesthesiologist, 8, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.AnesthesiaCode, 9);
            Value(x => x.AnesthesiaMinutes, 10);
            Value(x => x.Surgeon, 11, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ProcedurePractitioner, 12, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ConsentCode, 13);
            Value(x => x.ProcedurePriority, 14);
            Entity(x => x.AssociatedDiagnosisCode, 15);
            Entity(x => x.ProcedureCodeModifier, 16);
            Value(x => x.ProcedureDRGType, 17);
            Entity(x => x.TissueTypeCode, 18);
            Entity(x => x.ProcedureIdentifier, 19);
            Value(x => x.ProcedureActionCode, 20);
            Value(x => x.DRGProcedureDeterminationStatus, 21);
            Value(x => x.DRGProcedureRelevance, 22);
        }
    }
}