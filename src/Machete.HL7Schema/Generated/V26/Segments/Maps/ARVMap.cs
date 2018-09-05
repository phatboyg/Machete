// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ARV (SegmentMap) - Access Restriction
    /// </summary>
    public class ARVMap :
        HL7V26SegmentMap<ARV>
    {
        public ARVMap()
        {
            Id = "ARV";

            Name = "Access Restriction";

            Value(x => x.SetId, 1);
            Entity(x => x.AccessRestrictionActionCode, 2, x => {x.Required = true;});
            Entity(x => x.AccessRestrictionValue, 3, x => {x.Required = true;});
            Entity(x => x.AccessRestrictionReason, 4);
            Value(x => x.SpecialAccessRestrictionInstructions, 5);
            Entity(x => x.AccessRestrictionDateRange, 6);
        }
    }
}