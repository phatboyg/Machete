// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EVN (SegmentMap) - Event Type
    /// </summary>
    public class EVNMap :
        HL7V26SegmentMap<EVN>
    {
        public EVNMap()
        {
            Id = "EVN";

            Name = "Event Type";

            Value(x => x.EventTypeCode, 1);
            Value(x => x.RecordedDateTime, 2, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.DateTimePlannedEvent, 3, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EventReasonCode, 4);
            Entity(x => x.OperatorId, 5);
            Value(x => x.EventOccurred, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.EventFacility, 7);
        }
    }
}