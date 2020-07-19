// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFI (SegmentMap) - Master File Identification
    /// </summary>
    public class MFIMap :
        HL7V26SegmentMap<MFI>
    {
        public MFIMap()
        {
            Id = "MFI";

            Name = "Master File Identification";

            Entity(x => x.MasterFileIdentifier, 1, x => x.IsRequired());
            Entity(x => x.MasterFileApplicationIdentifier, 2);
            Value(x => x.FileLevelEventCode, 3, x => x.IsRequired());
            Value(x => x.EnteredDateTime, 4, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EffectiveDateTime, 5, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ResponseLevelCode, 6, x => x.IsRequired());
        }
    }
}