// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PES (SegmentMap) - Product Experience Sender
    /// </summary>
    public class PESMap :
        HL7V26SegmentMap<PES>
    {
        public PESMap()
        {
            Id = "PES";

            Name = "Product Experience Sender";

            Entity(x => x.SenderOrganizationName, 1);
            Entity(x => x.SenderIndividualName, 2);
            Entity(x => x.SenderAddress, 3);
            Entity(x => x.SenderTelephone, 4);
            Entity(x => x.SenderEventIdentifier, 5);
            Value(x => x.SenderSequenceNumber, 6);
            Value(x => x.SenderEventDescription, 7);
            Value(x => x.SenderComment, 8);
            Value(x => x.SenderAwareDateTime, 9, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EventReportDate, 10, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Value(x => x.EventReportTimingType, 11);
            Value(x => x.EventReportSource, 12);
            Value(x => x.EventReportedTo, 13);
        }
    }
}