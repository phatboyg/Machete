// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O36_SPECIMEN_CONTAINER (GroupMap) - 
    /// </summary>
    public class ORL_O36_SPECIMEN_CONTAINERMap :
        HL7V26LayoutMap<ORL_O36_SPECIMEN_CONTAINER>
    {
        public ORL_O36_SPECIMEN_CONTAINERMap()
        {
            Segment(x => x.SAC, 0, x => x.Required = true);
            Layout(x => x.Order, 1);
        }
    }
}