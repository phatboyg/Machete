// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXU_V04_PATIENT (GroupMap) - 
    /// </summary>
    public class VXU_V04_PATIENTMap :
        HL7TemplateMap<VXU_V04_PATIENT>
    {
        public VXU_V04_PATIENTMap()
        {
            Segment(x => x.PV1, 0, x => x.Required = true);
            Segment(x => x.PV2, 1);
        }
    }
}