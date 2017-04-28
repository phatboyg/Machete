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
        HL7SegmentMap<MFE>
    {
        public MFEMap()
        {
            Id = "MFE";

            Name = "Master File Entry";

            Value(x => x.RecordLevelEventCode, 1, x => {x.Required = true;});
            Value(x => x.MFNControlId, 2);
            Value(x => x.EffectiveDateTime, 3, x => {x.Format = "LONGDATETIME3";});
            Value(x => x.PrimaryKeyValue, 4, x => {x.Required = true;});
            Value(x => x.PrimaryKeyValueType, 5, x => {x.Required = true;});
            Value(x => x.EnteredDateTime, 6, x => {x.Format = "LONGDATETIME6";});
            Entity(x => x.EnteredBy, 7);
        }
    }
}