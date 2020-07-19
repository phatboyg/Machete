// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTH (SegmentMap) - Pathway
    /// </summary>
    public class PTHMap :
        HL7V26SegmentMap<PTH>
    {
        public PTHMap()
        {
            Id = "PTH";

            Name = "Pathway";

            Value(x => x.ActionCode, 1, x => x.IsRequired());
            Entity(x => x.PathwayId, 2, x => x.IsRequired());
            Entity(x => x.PathwayInstanceId, 3, x => x.IsRequired());
            Value(x => x.PathwayEstablishedDateTime, 4, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.PathwayLifeCycleStatus, 5);
            Value(x => x.ChangePathwayLifeCycleStatusDateTime, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.MoodCode, 7);
        }
    }
}