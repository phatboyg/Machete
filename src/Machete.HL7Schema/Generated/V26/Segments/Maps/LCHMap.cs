// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LCH (SegmentMap) - Location Characteristic
    /// </summary>
    public class LCHMap :
        HL7V26SegmentMap<LCH>
    {
        public LCHMap()
        {
            Id = "LCH";

            Name = "Location Characteristic";

            Entity(x => x.PrimaryKeyValue, 1, x => {x.Required = true;});
            Value(x => x.SegmentActionCode, 2);
            Entity(x => x.SegmentUniqueKey, 3);
            Entity(x => x.LocationCharacteristicId, 4, x => {x.Required = true;});
            Entity(x => x.LocationCharacteristicValue, 5, x => {x.Required = true;});
        }
    }
}