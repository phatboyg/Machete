// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFE (SegmentMap) - Master File Entry
    /// </summary>
    public class MFEMap :
        HL7V26SegmentMap<MFE>
    {
        public MFEMap()
        {
            Id = "MFE";

            Name = "Master File Entry";

            Value(x => x.RecordLevelEventCode, 1, x => x.IsRequired());
            Value(x => x.MFNControlId, 2);
            Value(x => x.EffectiveDateTime, 3, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.PrimaryKeyValue, 4, x => x.IsRequired());
            Value(x => x.PrimaryKeyValueType, 5, x => x.IsRequired());
            Value(x => x.EnteredDateTime, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.EnteredBy, 7);
        }
    }
}