// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORI_O24_PATIENT (GroupMap) - 
    /// </summary>
    public class ORI_O24_PATIENTMap :
        HL7TemplateMap<ORI_O24_PATIENT>
    {
        public ORI_O24_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}