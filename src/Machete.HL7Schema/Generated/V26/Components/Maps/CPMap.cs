// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CP (ComponentMap) - Composite Price
    /// </summary>
    public class CPMap :
        HL7ComponentMap<CP>
    {
        public CPMap()
        {
            Entity(x => x.Price, 0);
            Value(x => x.PriceType, 1);
            Value(x => x.FromValue, 2);
            Value(x => x.ToValue, 3);
            Entity(x => x.RangeUnits, 4);
            Value(x => x.RangeType, 5);
        }
    }
}