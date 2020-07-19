// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU (ComponentMap) - Channel Sensitivity and Units
    /// </summary>
    public class CSUMap :
        HL7V26ComponentMap<CSU>
    {
        public CSUMap()
        {
            Value(x => x.ChannelSensitivity, 0);
            Value(x => x.UnitOfMeasureIdentifier, 1);
            Value(x => x.UnitOfMeasureDescription, 2);
            Value(x => x.UnitOfMeasureCodingSystem, 3);
            Value(x => x.AlternateUnitOfMeasureIdentifier, 4);
            Value(x => x.AlternateUnitOfMeasureDescription, 5);
            Value(x => x.AlternateUnitOfMeasureCodingSystem, 6);
        }
    }
}