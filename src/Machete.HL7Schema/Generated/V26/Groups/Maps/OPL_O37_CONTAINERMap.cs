// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_CONTAINER (GroupMap) - 
    /// </summary>
    public class OPL_O37_CONTAINERMap :
        HL7TemplateMap<OPL_O37_CONTAINER>
    {
        public OPL_O37_CONTAINERMap()
        {
            Segment(x => x.SAC, 0, x => x.Required = true);
            Segments(x => x.OBX, 1);
        }
    }
}