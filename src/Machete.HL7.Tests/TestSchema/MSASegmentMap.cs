namespace Machete.HL7.Tests.TestSchema
{
    public class MSASegmentMap :
        HL7SegmentMap<MSASegment, HL7Entity>
    {
        public MSASegmentMap()
        {
            Id = "MSA";

            Name = "Message Acknowledgment";

            Value(x => x.AcknowledgmentCode, 1, x => x.IsRequired());
            Value(x => x.MessageControlId, 2, x => x.IsRequired());
            Value(x => x.TextMessage, 3);
            Value(x => x.ExpectedSequenceNumber, 4);
            Value(x => x.DelayedAcknowledgmentType, 5, x => {x.Converter = HL7ValueConverters.VariableLongDateTime;});
            Entity(x => x.ErrorCondition, 6);
            Value(x => x.MessageWaitingNumber, 7);
            Value(x => x.MessageWaitingPriority, 8);
        }
    }
}