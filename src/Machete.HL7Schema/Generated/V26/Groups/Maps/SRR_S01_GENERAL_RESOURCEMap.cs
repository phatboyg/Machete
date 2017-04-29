// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRR_S01_GENERAL_RESOURCE (GroupMap) - 
    /// </summary>
    public class SRR_S01_GENERAL_RESOURCEMap :
        HL7TemplateMap<SRR_S01_GENERAL_RESOURCE>
    {
        public SRR_S01_GENERAL_RESOURCEMap()
        {
            Segment(x => x.AIG, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}