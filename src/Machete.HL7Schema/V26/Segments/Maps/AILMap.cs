// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// AIL (SegmentMap) - Appointment Information - Location Resource
    /// </summary>
    public class AILMap :
        HL7V26SegmentMap<AIL>
    {
        public AILMap()
        {
            Id = "AIL";

            Name = "Appointment Information - Location Resource";

            Value(x => x.SetId, 1, x => x.IsRequired());
            Value(x => x.SegmentActionCode, 2);
            Entity(x => x.LocationResourceId, 3);
            Entity(x => x.LocationType, 4);
            Entity(x => x.LocationGroup, 5);
            Value(x => x.StartDateTime, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.StartDateTimeOffset, 7);
            Entity(x => x.StartDateTimeOffsetUnits, 8);
            Value(x => x.Duration, 9);
            Entity(x => x.DurationUnits, 10);
            Value(x => x.AllowSubstitutionCode, 11);
            Entity(x => x.FillerStatusCode, 12);
        }
    }
}