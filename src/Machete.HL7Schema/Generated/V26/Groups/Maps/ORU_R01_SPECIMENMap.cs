// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORU_R01_SPECIMEN (GroupMap) - 
    /// </summary>
    public class ORU_R01_SPECIMENMap :
        HL7TemplateMap<ORU_R01_SPECIMEN>
    {
        public ORU_R01_SPECIMENMap()
        {
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segments(x => x.OBX, 1);
        }
    }
}