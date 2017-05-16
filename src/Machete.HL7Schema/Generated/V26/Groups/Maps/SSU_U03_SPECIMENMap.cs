// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SSU_U03_SPECIMEN (GroupMap) - 
    /// </summary>
    public class SSU_U03_SPECIMENMap :
        HL7LayoutMap<SSU_U03_SPECIMEN>
    {
        public SSU_U03_SPECIMENMap()
        {
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segment(x => x.OBX, 1);
        }
    }
}