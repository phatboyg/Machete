// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O35_SPECIMEN_CONTAINER (GroupMap) - 
    /// </summary>
    public class OML_O35_SPECIMEN_CONTAINERMap :
        HL7TemplateMap<OML_O35_SPECIMEN_CONTAINER>
    {
        public OML_O35_SPECIMEN_CONTAINERMap()
        {
            Segment(x => x.SAC, 0, x => x.Required = true);
            Groups(x => x.Order, 1, x => x.Required = true);
        }
    }
}