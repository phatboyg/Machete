// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07_PEX_OBSERVATION (GroupMap) - 
    /// </summary>
    public class PEX_P07_PEX_OBSERVATIONMap :
        HL7TemplateMap<PEX_P07_PEX_OBSERVATION>
    {
        public PEX_P07_PEX_OBSERVATIONMap()
        {
            Segment(x => x.PEO, 0, x => x.Required = true);
            Groups(x => x.PexCause, 1, x => x.Required = true);
        }
    }
}