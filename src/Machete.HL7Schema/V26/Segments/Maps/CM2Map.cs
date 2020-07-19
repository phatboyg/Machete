// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CM2 (SegmentMap) - Clinical Study Schedule Master
    /// </summary>
    public class CM2Map :
        HL7V26SegmentMap<CM2>
    {
        public CM2Map()
        {
            Id = "CM2";

            Name = "Clinical Study Schedule Master";

            Value(x => x.SetId, 1);
            Entity(x => x.ScheduledTimePoint, 2, x => x.IsRequired());
            Value(x => x.DescriptionOfTimePoint, 3);
            Entity(x => x.EventScheduledThisTimePoint, 4, x => x.IsRequired());
        }
    }
}