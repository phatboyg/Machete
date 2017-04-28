// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// AIS (SegmentMap) - Appointment Information
    /// </summary>
    public class AISMap :
        HL7SegmentMap<AIS>
    {
        public AISMap()
        {
            Id = "AIS";

            Name = "Appointment Information";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Value(x => x.SegmentActionCode, 2);
            Entity(x => x.UniversalServiceIdentifier, 3, x => {x.Required = true;});
            Value(x => x.StartDateTime, 4, x => {x.Format = "LONGDATETIME4";});
            Value(x => x.StartDateTimeOffset, 5);
            Entity(x => x.StartDateTimeOffsetUnits, 6);
            Value(x => x.Duration, 7);
            Entity(x => x.DurationUnits, 8);
            Value(x => x.AllowSubstitutionCode, 9);
            Entity(x => x.FillerStatusCode, 10);
            Entity(x => x.PlacerSupplementalServiceInformation, 11);
            Entity(x => x.FillerSupplementalServiceInformation, 12);
        }
    }
}