// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RCI_I05_RESULTS (GroupMap) - 
    /// </summary>
    public class RCI_I05_RESULTSMap :
        HL7TemplateMap<RCI_I05_RESULTS>
    {
        public RCI_I05_RESULTSMap()
        {
            Map(x => x.OBX, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}