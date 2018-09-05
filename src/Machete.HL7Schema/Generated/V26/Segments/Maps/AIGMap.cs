// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// AIG (SegmentMap) - Appointment Information - General Resource
    /// </summary>
    public class AIGMap :
        HL7V26SegmentMap<AIG>
    {
        public AIGMap()
        {
            Id = "AIG";

            Name = "Appointment Information - General Resource";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.SegmentActionCode, 2);
            Entity(x => x.ResourceId, 3);
            Entity(x => x.ResourceType, 4, x => x.IsRequired());
            Entity(x => x.ResourceGroup, 5);
            Value(x => x.ResourceQuantity, 6);
            Entity(x => x.ResourceQuantityUnits, 7);
            Value(x => x.StartDateTime, 8, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.StartDateTimeOffset, 9);
            Entity(x => x.StartDateTimeOffsetUnits, 10);
            Value(x => x.Duration, 11);
            Entity(x => x.DurationUnits, 12);
            Value(x => x.AllowSubstitutionCode, 13);
            Entity(x => x.FillerStatusCode, 14);
        }
    }
}