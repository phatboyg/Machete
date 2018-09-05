// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NTE (SegmentMap) - Notes and Comments
    /// </summary>
    public class NTEMap :
        HL7V26SegmentMap<NTE>
    {
        public NTEMap()
        {
            Id = "NTE";

            Name = "Notes and Comments";

            Value(x => x.SetId, 1);
            Value(x => x.SourceOfComment, 2);
            Value(x => x.Comment, 3);
            Entity(x => x.CommentType, 4);
            Entity(x => x.EnteredBy, 5);
            Value(x => x.EnteredDateTime, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EffectiveStartDate, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ExpirationDate, 8, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
        }
    }
}