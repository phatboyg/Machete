// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M16_MATERIAL_LOCATION (GroupMap) - 
    /// </summary>
    public class MFN_M16_MATERIAL_LOCATIONMap :
        HL7V26LayoutMap<MFN_M16_MATERIAL_LOCATION>
    {
        public MFN_M16_MATERIAL_LOCATIONMap()
        {
            Segment(x => x.IVT, 0, x => x.Required = true);
            Segment(x => x.ILT, 1);
            Segment(x => x.NTE, 2);
        }
    }
}