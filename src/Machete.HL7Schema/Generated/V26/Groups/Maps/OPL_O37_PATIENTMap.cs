// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPL_O37_PATIENT (GroupMap) - 
    /// </summary>
    public class OPL_O37_PATIENTMap :
        HL7TemplateMap<OPL_O37_PATIENT>
    {
        public OPL_O37_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PD1, 1);
            Map(x => x.OBX, 2);
            Map(x => x.Insurance, 3);
            Map(x => x.AL1, 4);
        }
    }
}