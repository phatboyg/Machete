// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTR_PCF_PATHWAY_ROLE (GroupMap) - 
    /// </summary>
    public class PTR_PCF_PATHWAY_ROLEMap :
        HL7V26LayoutMap<PTR_PCF_PATHWAY_ROLE>
    {
        public PTR_PCF_PATHWAY_ROLEMap()
        {
            Segment(x => x.ROL, 0, x => x.Required = true);
            Segment(x => x.VAR, 1);
        }
    }
}