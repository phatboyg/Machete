// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// UVC (ComponentMap) - UB Value Code and Amount
    /// </summary>
    public class UVCMap :
        HL7V26ComponentMap<UVC>
    {
        public UVCMap()
        {
            Entity(x => x.ValueCode, 0);
            Entity(x => x.ValueAmount, 1);
        }
    }
}