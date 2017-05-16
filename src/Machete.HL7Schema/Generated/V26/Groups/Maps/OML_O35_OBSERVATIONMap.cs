// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O35_OBSERVATION (GroupMap) - 
    /// </summary>
    public class OML_O35_OBSERVATIONMap :
        HL7LayoutMap<OML_O35_OBSERVATION>
    {
        public OML_O35_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.TCD, 1);
            Segment(x => x.NTE, 2);
        }
    }
}