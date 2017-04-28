// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M03_MF_TEST (GroupMap) - 
    /// </summary>
    public class MFN_M03_MF_TESTMap :
        HL7TemplateMap<MFN_M03_MF_TEST>
    {
        public MFN_M03_MF_TESTMap()
        {
            Map(x => x.MFE, 0, x => x.Required = true);
            Map(x => x.OM1, 1, x => x.Required = true);
            Map(x => x.Hxx, 2, x => x.Required = true);
        }
    }
}