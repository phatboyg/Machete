// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORF_R04_OBSERVATION (GroupMap) - 
    /// </summary>
    public class ORF_R04_OBSERVATIONMap :
        HL7TemplateMap<ORF_R04_OBSERVATION>
    {
        public ORF_R04_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0);
            Segments(x => x.NTE, 1);
        }
    }
}