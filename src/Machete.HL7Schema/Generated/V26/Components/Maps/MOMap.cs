// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MO (ComponentMap) - Money
    /// </summary>
    public class MOMap :
        HL7V26ComponentMap<MO>
    {
        public MOMap()
        {
            Value(x => x.Quantity, 0);
            Value(x => x.Denomination, 1);
        }
    }
}