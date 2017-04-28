// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMI_O23_ORDER (GroupMap) - 
    /// </summary>
    public class OMI_O23_ORDERMap :
        HL7TemplateMap<OMI_O23_ORDER>
    {
        public OMI_O23_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OBR, 2, x => x.Required = true);
            Map(x => x.NTE, 3);
            Map(x => x.ROL, 4);
            Map(x => x.CTD, 5);
            Map(x => x.DG1, 6);
            Map(x => x.Observation, 7);
            Map(x => x.IPC, 8, x => x.Required = true);
        }
    }
}