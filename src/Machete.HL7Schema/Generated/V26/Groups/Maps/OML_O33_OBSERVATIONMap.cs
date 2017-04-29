// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O33_OBSERVATION (GroupMap) - 
    /// </summary>
    public class OML_O33_OBSERVATIONMap :
        HL7TemplateMap<OML_O33_OBSERVATION>
    {
        public OML_O33_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.TCD, 1);
            Segments(x => x.NTE, 2);
        }
    }
}