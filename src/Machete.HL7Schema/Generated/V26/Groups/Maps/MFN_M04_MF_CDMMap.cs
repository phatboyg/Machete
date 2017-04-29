// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M04_MF_CDM (GroupMap) - 
    /// </summary>
    public class MFN_M04_MF_CDMMap :
        HL7TemplateMap<MFN_M04_MF_CDM>
    {
        public MFN_M04_MF_CDMMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.CDM, 1, x => x.Required = true);
            Segments(x => x.PRC, 2);
        }
    }
}