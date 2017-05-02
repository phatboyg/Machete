// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DTN (ComponentMap) - Day Type and Number
    /// </summary>
    public class DTNMap :
        HL7ComponentMap<DTN>
    {
        public DTNMap()
        {
            Value(x => x.DayType, 0);
            Value(x => x.NumberOfDays, 1);
        }
    }
}