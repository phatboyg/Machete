// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VR (ComponentMap) - Value Range
    /// </summary>
    public class VRMap :
        HL7V26ComponentMap<VR>
    {
        public VRMap()
        {
            Value(x => x.FirstDataCodeValue, 0);
            Value(x => x.LastDataCodeValue, 1);
        }
    }
}