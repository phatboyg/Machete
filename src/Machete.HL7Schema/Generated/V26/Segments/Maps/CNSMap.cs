// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CNS (SegmentMap) - Clear Notification
    /// </summary>
    public class CNSMap :
        HL7SegmentMap<CNS>
    {
        public CNSMap()
        {
            Id = "CNS";

            Name = "Clear Notification";

            Value(x => x.StartingNotificationReferenceNumber, 1);
            Value(x => x.EndingNotificationReferenceNumber, 2);
            Value(x => x.StartingNotificationDateTime, 3, x => {x.Format = "LONGDATETIME3";});
            Value(x => x.EndingNotificationDateTime, 4, x => {x.Format = "LONGDATETIME4";});
            Entity(x => x.StartingNotificationCode, 5);
            Entity(x => x.EndingNotificationCode, 6);
        }
    }
}