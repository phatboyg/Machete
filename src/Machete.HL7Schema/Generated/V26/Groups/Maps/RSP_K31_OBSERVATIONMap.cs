// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_K31_OBSERVATION (GroupMap) - 
    /// </summary>
    public class RSP_K31_OBSERVATIONMap :
        HL7LayoutMap<RSP_K31_OBSERVATION>
    {
        public RSP_K31_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0);
            Segment(x => x.NTE, 1);
        }
    }
}