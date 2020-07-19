// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// APR (SegmentMap) - Appointment Preferences
    /// </summary>
    public class APRMap :
        HL7V26SegmentMap<APR>
    {
        public APRMap()
        {
            Id = "APR";

            Name = "Appointment Preferences";

            Entity(x => x.TimeSelectionCriteria, 1);
            Entity(x => x.ResourceSelectionCriteria, 2);
            Entity(x => x.LocationSelectionCriteria, 3);
            Value(x => x.SlotSpacingCriteria, 4);
            Entity(x => x.FillerOverrideCriteria, 5);
        }
    }
}