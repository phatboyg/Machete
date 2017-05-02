// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MOC (ComponentMap) - Money and Code
    /// </summary>
    public class MOCMap :
        HL7ComponentMap<MOC>
    {
        public MOCMap()
        {
            Entity(x => x.MonetaryAmount, 0);
            Entity(x => x.ChargeCode, 1);
        }
    }
}