// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NST (SegmentMap) - Application control level statistics
    /// </summary>
    public class NSTMap :
        HL7V26SegmentMap<NST>
    {
        public NSTMap()
        {
            Id = "NST";

            Name = "Application control level statistics";

            Value(x => x.StatisticAvailable, 1, x => x.IsRequired());
            Value(x => x.SourceIdentifier, 2);
            Value(x => x.SourceType, 3);
            Value(x => x.StatisticStart, 4, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.StatisticEnd, 5, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ReceiveCharacterCount, 6);
            Value(x => x.SendCharacterCount, 7);
            Value(x => x.MessageReceived, 8);
            Value(x => x.MessageSent, 9);
            Value(x => x.ChecksumErrorsReceived, 10);
            Value(x => x.LengthErrorsReceived, 11);
            Value(x => x.OtherErrorsReceived, 12);
            Value(x => x.ConnectTimeouts, 13);
            Value(x => x.ReceiveTimeouts, 14);
            Value(x => x.ApplicationControlLevelErrors, 15);
        }
    }
}