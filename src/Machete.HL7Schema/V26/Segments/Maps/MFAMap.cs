// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFA (SegmentMap) - Master File Acknowledgment
    /// </summary>
    public class MFAMap :
        HL7V26SegmentMap<MFA>
    {
        public MFAMap()
        {
            Id = "MFA";

            Name = "Master File Acknowledgment";

            Value(x => x.RecordLevelEventCode, 1, x => x.IsRequired());
            Value(x => x.MFNControlId, 2);
            Value(x => x.EventCompletionDateTime, 3, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.MFNRecordLevelErrorReturn, 4, x => x.IsRequired());
            Value(x => x.PrimaryKeyValue, 5, x => x.IsRequired());
            Value(x => x.PrimaryKeyValueType, 6, x => x.IsRequired());
        }
    }
}