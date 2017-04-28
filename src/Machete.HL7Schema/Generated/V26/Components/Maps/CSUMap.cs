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
        HL7ComponentMap<CSU>
    {
        public CSUMap()
        {
            Value(x => x.ChannelSensitivity, 1);
            Value(x => x.UnitOfMeasureIdentifier, 2);
            Value(x => x.UnitOfMeasureDescription, 3);
            Value(x => x.UnitOfMeasureCodingSystem, 4);
            Value(x => x.AlternateUnitOfMeasureIdentifier, 5);
            Value(x => x.AlternateUnitOfMeasureDescription, 6);
            Value(x => x.AlternateUnitOfMeasureCodingSystem, 7);
        }
    }
}