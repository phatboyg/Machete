// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMD_O03_OBSERVATION (GroupMap) - 
    /// </summary>
    public class OMD_O03_OBSERVATIONMap :
        HL7LayoutMap<OMD_O03_OBSERVATION>
    {
        public OMD_O03_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}