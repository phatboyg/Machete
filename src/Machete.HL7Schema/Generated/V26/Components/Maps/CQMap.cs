// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CQ (ComponentMap) - Composite Quantity with Units
    /// </summary>
    public class CQMap :
        HL7ComponentMap<CQ>
    {
        public CQMap()
        {
            Value(x => x.Quantity, 1);
            Entity(x => x.Units, 2);
        }
    }
}