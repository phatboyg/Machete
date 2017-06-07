// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M16_PURCHASING_VENDOR (GroupMap) - 
    /// </summary>
    public class MFN_M16_PURCHASING_VENDORMap :
        HL7V26LayoutMap<MFN_M16_PURCHASING_VENDOR>
    {
        public MFN_M16_PURCHASING_VENDORMap()
        {
            Segment(x => x.VND, 0, x => x.Required = true);
            Layout(x => x.Packaging, 1);
        }
    }
}