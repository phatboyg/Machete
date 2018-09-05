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
        HL7V26SegmentMap<NDS>
    {
        public NDSMap()
        {
            Id = "NDS";

            Name = "Notification Detail";

            Value(x => x.NotificationReferenceNumber, 1, x => x.IsRequired());
            Value(x => x.NotificationDateTime, 2, x =>
            {
                x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;
                x.IsRequired();
            });
            Entity(x => x.NotificationAlertSeverity, 3, x => x.IsRequired());
            Entity(x => x.NotificationCode, 4, x => x.IsRequired());
        }
    }
}