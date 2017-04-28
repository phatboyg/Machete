// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DB1 (SegmentMap) - Disability
    /// </summary>
    public class DB1Map :
        HL7SegmentMap<DB1>
    {
        public DB1Map()
        {
            Id = "DB1";

            Name = "Disability";

            Value(x => x.SetId, 1, x => {x.Required = true;});
            Value(x => x.DisabledPersonCode, 2);
            Entity(x => x.DisabledPersonIdentifier, 3);
            Value(x => x.DisabilityIndicator, 4);
            Value(x => x.DisabilityStartDate, 5, x => {x.Format = "LONGDATE5";});
            Value(x => x.DisabilityEndDate, 6, x => {x.Format = "LONGDATE6";});
            Value(x => x.DisabilityReturnToWorkDate, 7, x => {x.Format = "LONGDATE7";});
            Value(x => x.DisabilityUnableToWorkDate, 8, x => {x.Format = "LONGDATE8";});
        }
    }
}