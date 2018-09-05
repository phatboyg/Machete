// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MSA (SegmentMap) - Message Acknowledgment
    /// </summary>
    public class MSAMap :
        HL7V26SegmentMap<MSA>
    {
        public MSAMap()
        {
            Id = "MSA";

            Name = "Message Acknowledgment";

            Value(x => x.AcknowledgmentCode, 1, x => x.IsRequired());
            Value(x => x.MessageControlId, 2, x => x.IsRequired());
            Value(x => x.TextMessage, 3);
            Value(x => x.ExpectedSequenceNumber, 4);
            Value(x => x.DelayedAcknowledgmentType, 5, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.ErrorCondition, 6);
            Value(x => x.MessageWaitingNumber, 7);
            Value(x => x.MessageWaitingPriority, 8);
        }
    }
}