// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQA_I08_RESULTS (GroupMap) - 
    /// </summary>
    public class RQA_I08_RESULTSMap :
        HL7TemplateMap<RQA_I08_RESULTS>
    {
        public RQA_I08_RESULTSMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}