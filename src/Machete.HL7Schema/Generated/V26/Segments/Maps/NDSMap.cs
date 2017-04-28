// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NDS (SegmentMap) - Notification Detail
    /// </summary>
    public class NDSMap :
        HL7SegmentMap<NDS>
    {
        public NDSMap()
        {
            Id = "NDS";

            Name = "Notification Detail";

            Value(x => x.NotificationReferenceNumber, 1, x => {x.Required = true;});
            Value(x => x.NotificationDateTime, 2, x => {x.Format = "LONGDATETIME2";x.Required = true;});
            Entity(x => x.NotificationAlertSeverity, 3, x => {x.Required = true;});
            Entity(x => x.NotificationCode, 4, x => {x.Required = true;});
        }
    }
}